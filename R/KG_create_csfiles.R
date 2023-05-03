# tcltkパッケージの読み込み
# Load tcltk package.
library("tcltk")

# openxlsxパッケージがなければインストール
# Install openxlsx package if it is not already there.
if(!require("openxlsx", quietly = TRUE)){
  install.packages("openxlsx");require("openxlsx")
}

# tidyverseパッケージがなければインストール
# Install tidyverse package if it is not already there.
if(!require("tidyverse", quietly = TRUE)){
  install.packages("tidyverse");require("tidyverse")
}

# ExsampleDataの"KG_Shortcut.xlsx"の読込み: openxlsx::read.xlsxコマンド
# Open ExsampleData folder "KG_Shortcut.xlsx": openxlsx::read.xlsx command.
# xlsxファイルを選択/Select xlsx file.
XLPath <- paste0(as.character(
  tkgetOpenFile(title = "xlsxファイルを選択",
                filetypes = '{"xlsxファイル" {".xlsx"}}',
                initialfile = c("*.xlsx"))), collapse = " ")

# 読み込み
# Read.
GetData <- read.xlsx(xlsxFile = XLPath, sheet = 1)

# KG_cs_template.Rを読み込み
# Open KG_cs_template.R
source("KG_cs_template.R")

# CSファイルの保存先を指定
# Specify where to save CS files
setwd(choose.dir())
#setwd("../ExsampleData/CS")

# データ処理とCSファイルの保存
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
