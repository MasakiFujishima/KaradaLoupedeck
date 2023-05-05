#' Create C# files from "KG_Shortcut.xlsx"
#'
#' \code{kg_csfiles_create} This function create C# files from "KG_Shortcut.xlsx".
#' @importFrom glue glue
#' @importFrom openxlsx read.xlsx write.xlsx
#' @param path xlsx file path.
#' @param savepath Specify where to save CS files.
#'
#' @return C# Source Files
#' @export
#' @examples
#' library("tcltk")
#' XLPath <- paste0(as.character(
#'   tkgetOpenFile(title = "Select xlsx file",
#'                 filetypes = '{"xlsx file" {".xlsx"}}',
#'                 initialfile = c("*.xlsx"))), collapse = " ")
#' kg_csfiles_create(path, savepath = choose.dir())
kg_csfiles_create <- function(path, savepath = choose.dir()){

  # Read.
  GetData <- read.xlsx(xlsxFile = path, sheet = 1)

  # Open inst/cs_template
  system.file("/inst", package = "KGLoupedeck")

  # Specify where to save CS files
  setwd(savepath)
  #setwd("../ExsampleData/CS")

  # Data processing and save cs files.
  for(i in seq(nrow(GetData))){

    FUNK_NAME <- GetData$FunName[i]
    DIS_NAME <- GetData$Description[i]
    CATE_NAME <- GetData$Category[i]
    TEXT_COL <- GetData$`TextColor(r,g,b)`[i]
    VK <- GetData$VK[i]
    MK <- GetData$MK[i]

    if(MK == ""){

      if(is.na(VK)){

        NULL

      }else{

        Processing <- VK_vec
        Fun_GetData <- glue::glue(Processing, .open = "{{", .close = "}}")
        write(Fun_GetData, file = paste0(DIS_NAME, ".cs"))

      }

    }else{

      Processing <- VK_MK_vec
      Fun_GetData <- glue::glue(Processing, .open = "{{", .close = "}}")
      write(Fun_GetData, file = paste0(DIS_NAME, ".cs"))

    }
  }
}
