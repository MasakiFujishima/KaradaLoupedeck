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

# キーボードショートカットのエクセルファイルを読込み: openxlsx::read.xlsxコマンド
# Open keybord shortcut Excel file: openxlsx::read.xlsx command.
# xlsxファイルを選択/Select xlsx file.
XLPath <- paste0(as.character(
  tkgetOpenFile(title = "xlsxファイルを選択",
                filetypes = '{"xlsxファイル" {".xlsx"}}',
                initialfile = c("*.xlsx"))), collapse = " ")

# 読み込み
# Read.
GetData <- read.xlsx(xlsxFile = XLPath, sheet = 1)

# データ処理
# Data processing.
AnaData <- GetData %>%
  # Description列に含まれる/,&,(,)を削除
  # Remove /,&,(,) in Description column.
  mutate(Description = str_replace_all(Description, pattern = "/|&", " ")) %>%
  mutate(Description = str_replace_all(Description, pattern = "\\(|\\)", "")) %>%
  mutate(FunName = str_replace_all(Description, pattern = " ", "_")) %>%
  
  # win/Macのショートカット列をタイトル表記(先頭を大文字)にする
  # Win/Mac shortcut columns with title notation (first letter capitalized).
  mutate(Windows = str_to_lower(Windows)) %>%
  
  # ModifierKey(MK),VirtualKeyCode(VK)を作成
  # Create ModifierKey(MK),VirtualKeyCode(VK).
  mutate(MK = str_extract_all(Windows, pattern = "shift|alt|ctrl", simplify = FALSE)) %>%
  mutate(VK = str_replace_all(Windows, pattern = "shift|alt|ctrl", replacement = "")) %>%
  
  ###ModifierKey(MK)の処理/Processing ModifierKey(MK)#####
  # MKのキー名タイトル表記(先頭を大文字)にする
  # MK key name title notation (first letter capitalized).
  # Ctrl,Shift,Altのみ/Ctrl,Shift,Alt only.
  mutate(MK = map(MK, ~str_to_title(.))) %>%
  # 記述をModifierKey.XX | ModifierKey.YYにする
  # Make the description ModifierKey.XX | ModifierKey.YY.
  mutate(MK = map(MK, ~str_c("ModifierKey.", ., collapse = " | "))) %>%
  ########
  
  ###VirtualKeyCode(VK)の処理/Processing ModifierKey(VK)#####
  # 対象となるソフトウェアのショートカットに合わせて適時追加
  # Add in a timely manner according to target software shortcuts.
　# replacementはVirtual-Key Codesを参照:
  # https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
  # ショートカットコマンド内の"+"を削除/Remove "+" in shortcut commands.
  mutate(VK = str_replace_all(VK, pattern = "\\+", replacement = "")) %>%
  mutate(VK = str_replace_all(VK, pattern = "\\.", replacement = "Period")) %>%
  mutate(VK = str_replace_all(VK, pattern = "-", replacement = "Minus")) %>%
  mutate(VK = str_replace_all(VK, pattern = "/", replacement = "OEM2")) %>%
  mutate(VK = str_replace_all(VK, pattern = "up", replacement = "ArrowUp")) %>%
  mutate(VK = str_replace_all(VK, pattern = "down", replacement = "ArrowDown")) %>%
  mutate(VK = str_replace_all(VK, pattern = "right", replacement = "ArrowRight")) %>%
  mutate(VK = str_replace_all(VK, pattern = "left", replacement = "ArrowLeft")) %>%
  
  # ショートカットコマンド内の"No Shortcut"を削除/Remove "No Shortcut" in shortcut commands.
  # ソフトウェアの表記に合わせて変更する/Change to match software notation.
  mutate(VK = str_replace_all(VK, pattern = "No Shortcut", replacement = "")) %>%
  
  # VKのキー名タイトル表記(先頭を大文字)にする
  # VK key name title notation (first letter capitalized)
  mutate(VK = str_to_title(VK)) %>%
  
  # 数値のみの記述をNumPadXXにする
  # Numeric-only descriptions to NumPadXX.
  mutate(VK = str_replace_all(VK, pattern = "^[(^\\W\\d)](\\d{0,2})",
                              replacement = str_c("NumPad", VK))) %>%
  # 英字のみの記述をKeyXXにする
  # Alphabet-only description to KeyXX.
  mutate(VK = str_replace_all(VK, pattern = "[A-Z]{1}$",
                              replacement = str_c("Key", VK))) %>%
  # 必要データを選択
  # Select data.
  select(-Mac)
  
# エクセルで保存
# Save xlsx file. 
write.xlsx(x = AnaData,
           file = "KG_Shortcut.xlsx",
           overwrite = TRUE)
