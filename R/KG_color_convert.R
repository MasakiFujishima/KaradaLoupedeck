# openxlsxパッケージがなければインストール
# Install openxlsx package if it is not already there.
if(!require("openxlsx", quietly = TRUE)){
  install.packages("openxlsx");require("openxlsx")
}

# tcltkパッケージの読み込み
# Load tcltk package.
library("tcltk")

# キーボードショートカットのエクセルファイルを読込み: openxlsx::read.xlsxコマンド
# Open keybord shortcut Excel file: openxlsx::read.xlsx command.
# xlsxファイルを選択/Select xlsx file.
XLPath <- paste0(as.character(
  tkgetOpenFile(title = "xlsxファイルを選択",
                filetypes = '{"xlsxファイル" {".xlsx"}}',
                initialfile = c("*.xlsx"))), collapse = " ")

# 読み込み
# Read.
GetData <- loadWorkbook(xlsxFile = XLPath)
Test <- getStyles(GetData)[1]

grDevices::colorRamp(colors = "#fcc800", space = "rgb")(1)
