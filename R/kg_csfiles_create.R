#' Create C# files from "KG_Shortcut.xlsx"
#'
#' \code{kg_csfiles_create} This function create C# files from "KG_Shortcut.xlsx".
#' @importFrom glue glue
#' @importFrom openxlsx read.xlsx write.xlsx
#' @importFrom utils choose.dir
#' @param xlsxFile An xlsx file.
#' @param savepath Specify where to save CS files.
#'
#' @return C# Source Files
#' @export
#' @examples
#' kg_csfiles_create(xlsxFile = "../ExsampleData/KG_Shortcut.xlsx", savepath = getwd())
kg_csfiles_create <- function(xlsxFile, savepath){

  # Read.
  GetData <- openxlsx::read.xlsx(xlsxFile, sheet = 1)

  # Open extdata/docs/cs_template
  system.file("extdata/docs", package = "karadaLoupedeck")

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
