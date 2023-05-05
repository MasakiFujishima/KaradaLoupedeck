#' keyboard shortcuts excel file tidy
#'
#' \code{kg_scef_tidy} This function keyboard shortcuts excel file tidy.
#' @importFrom tidyxl xlsx_formats xlsx_cells
#' @importFrom dplyr mutate select filter
#' @importFrom magrittr %>%
#' @importFrom stringr str_replace_all str_extract_all str_c str_to_lower str_to_title
#' @importFrom grDevices colorRamp rgb
#' @importFrom openxlsx read.xlsx write.xlsx writeData createStyle addStyle
#' @importFrom purrr map
#' @importFrom tidyselect any_of
#' @param xlsxFile An xlsx file.
#' @param fillcol fill color column Number.
#' @param textcol text color column Number.
#' @param ncol number of columns in the Excel file.
#' @param select_OS Select Windows or Mac.
#'
#' @return an Excel file named "KG_Shortcut" is created in the working folder
#' @export
#' @examples
#' kg_scef_tidy(xlsxFile)
kg_scef_tidy <- function(xlsxFile, fillcol = 2, textcol = 3, ncol = 6, select_OS = "Windows"){

  # Read.
  GetData <- openxlsx::read.xlsx(xlsxFile, sheet = 1)

  # OS select.
  if(select_OS == "Windows"){

    delete_OS <- "Mac"

  }else{

    delete_OS <- "Windows"

    }

  # Data processing.
  ResultData <- GetData %>%
    # Remove /,&,(,) in Description column.
    dplyr::mutate(Description = stringr::str_replace_all(Description, pattern = "/|&", " ")) %>%
    dplyr::mutate(Description = stringr::str_replace_all(Description, pattern = "\\(|\\)|-|\\+", "")) %>%
    dplyr::mutate(Description = stringr::str_to_title(Description)) %>%
    dplyr::mutate(FunName = stringr::str_replace_all(Description, pattern = " ", "")) %>%

    # Lowercase the win/Mac shortcut column.
    dplyr::mutate(Windows = stringr::str_to_lower(Windows)) %>%

    # Create ModifierKey(MK),VirtualKeyCode(VK).
    dplyr::mutate(Windows = stringr::str_replace_all(Windows, pattern = "ctrl", replacement = "control")) %>%
    dplyr::mutate(MK = stringr::str_extract_all(Windows, pattern = "shift|alt|control", simplify = FALSE)) %>%
    dplyr::mutate(VK = stringr::str_replace_all(Windows, pattern = "shift|alt|control", replacement = "")) %>%

    ###Processing ModifierKey(MK)#####
    # MK key name title notation (first letter capitalized).
    # Ctrl,Shift,Alt only.
    dplyr::mutate(MK = purrr::map(MK, ~str_to_title(.))) %>%

    # Make the description ModifierKey.XX | ModifierKey.YY.
    dplyr::mutate(MK = purrr::map(MK, ~stringr::str_c("ModifierKey.", ., collapse = " | "))) %>%
    ########

    ###VirtualKeyCode(VK)の処理/Processing ModifierKey(VK)#####
    # Remove "+" in shortcut commands.
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "\\+", replacement = "")) %>%

    # Add in a timely manner according to target software shortcuts.
    # https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "tab", replacement = "Tab")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "esc", replacement = "Escape")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "enter", replacement = "Return")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "spacebar", replacement = "Space")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "\\.", replacement = "Period")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "-", replacement = "Minus")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "/", replacement = "Oem2")) %>%

    # VK key name title notation (first letter capitalized)
    dplyr::mutate(VK = stringr::str_to_title(VK)) %>%

    # Add in a timely manner according to target software shortcuts.
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "Up", replacement = "ArrowUp")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "Down", replacement = "ArrowDown")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "Right", replacement = "ArrowRight")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "Left", replacement = "ArrowLeft")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "Pageup|Pgup", replacement = "PageUp")) %>%
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "Pagedown|Pgdn", replacement = "PageDown")) %>%

    # Numeric-only descriptions to NumPadXX.
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "^[(^\\W\\d)](\\d{0,2})",
                                                    replacement = stringr::str_c("NumPad", VK))) %>%
    # Alphabet-only description to KeyXX.
    dplyr::mutate(VK = stringr::str_replace_all(VK, pattern = "[A-Z]{1}$",
                                                    replacement = stringr::str_c("Key", VK))) %>%
    # Select data.
    dplyr::select(-tidyselect::any_of(delete_OS))

  # Return fill and text color in a data frame
  ft_color <- kg_xlsx_color(xlsxFile, fillcol = 2, textcol = 3, ncol = 6)

  # Add ft_color to ResultData
  ResultData[, 2:3] <- ft_color


  # Remove "No Shortcut" in shortcut commands.
  # Change to match software notation.
  ResultData <- ResultData %>%
    dplyr::filter(.data[[select_OS]] != "no shortcut")

  # Clleate new xlsx book.
  newWb <- openxlsx::createWorkbook()

  # Add worksheet.
  openxlsx::addWorksheet(wb = newWb,
                         sheetName = "keyboard shortcuts",
                         gridLines = FALSE, tabColour = "blue",
                         zoom = 80)

  # Write data.
  openxlsx::writeData(wb = newWb, sheet = 1, x = ResultData,
                      startRow = 1, startCol = 1)

  # Write fill color.
  for(i in seq(nrow(ResultData))){

    # Icon_Fill_Color
    fill_rgb <- unlist(strsplit(ResultData[i, 2], ","))
    Icon_Fill_Color <- openxlsx::createStyle(fgFill = grDevices::rgb(fill_rgb[1],
                                                                     fill_rgb[2],
                                                                     fill_rgb[3],
                                                                     maxColorValue = 255))
    # Icon_Text_Color
    text_rgb <- unlist(strsplit(ResultData[i, 3], ","))
    Icon_Text_Color <- openxlsx::createStyle(fgFill = grDevices::rgb(text_rgb[1],
                                                                     text_rgb[2],
                                                                     text_rgb[3],
                                                                     maxColorValue = 255))

    # addstyle Icon_Fill_Color
    addStyle(wb = newWb, sheet = 1,
             style = Icon_Fill_Color,
             rows = i + 1, cols = 2)

    # addstyle Icon_Text_Color
    addStyle(wb = newWb, sheet = 1,
             style = Icon_Text_Color,
             rows = i + 1, cols = 3)
  }

  # Save xlsx file.
  openxlsx::saveWorkbook(wb = newWb,
                         file = "KG_Shortcut.xlsx",
                         overwrite = TRUE)

}

