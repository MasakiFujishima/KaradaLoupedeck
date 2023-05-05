#' Get icon color data from keyboard shortcut excel file
#'
#' \code{kg_xlsx_color} This function Get icon color data from
#'     keyboard shortcut excel file.
#' @importFrom tidyxl xlsx_formats xlsx_cells
#' @importFrom grDevices colorRamp
#' @importFrom magrittr %>%
#' @importFrom stringr str_replace_all str_c
#' @param path xlsx file path.
#' @param fillcol fill color column Number.
#' @param textcol text color column Number.
#' @param ncol number of columns in the Excel file.
#'
#' @return Return fill and text color in a data frame
#' @export
#' @examples
#' library("tcltk")
#' XLPath <- paste0(as.character(
#'   tkgetOpenFile(title = "Select xlsx file",
#'                 filetypes = '{"xlsx file" {".xlsx"}}',
#'                 initialfile = c("*.xlsx"))), collapse = " ")
#' kg_xlsx_color(path = XLPath, fillcol = 2, textcol = 3, ncol = 6)
kg_xlsx_color <- function(path, fillcol = 2, textcol = 3, ncol = 6){

  get_formats <- tidyxl::xlsx_formats(path)
  get_cells <- tidyxl::xlsx_cells(path, include_blank_cells = TRUE)

  get_colordatas <- get_formats$local$fill$patternFill$fgColor$rgb[get_cells$local_format_id] %>%
    sapply(function(x) stringr::str_replace_all(pattern = "FF",
                                                replacement = "#",
                                                as.character(x))) %>%
    matrix(ncol, byrow = TRUE)

  result_data <- get_colordatas[-1, c(fillcol, textcol)] %>%
    sapply(function(x) grDevices::colorRamp(colors = x, space = "rgb")(1)) %>%
    apply(2, function(x) stringr::str_c(x, collapse = ",")) %>%
    matrix(ncol = 2, byrow = FALSE) %>%
    as.data.frame()

  colnames(result_data) <- c("Icon_Fill_Color", "Icon_Text_Color")
  return(result_data)

}
