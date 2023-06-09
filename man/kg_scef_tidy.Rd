% Generated by roxygen2: do not edit by hand
% Please edit documentation in R/kg_scef_tidy.R
\name{kg_scef_tidy}
\alias{kg_scef_tidy}
\title{keyboard shortcuts excel file tidy}
\usage{
kg_scef_tidy(
  xlsxFile,
  fillcol = 2,
  textcol = 3,
  ncol = 6,
  select_OS = "Windows"
)
}
\arguments{
\item{xlsxFile}{An xlsx file.}

\item{fillcol}{fill color column Number.}

\item{textcol}{text color column Number.}

\item{ncol}{number of columns in the Excel file.}

\item{select_OS}{Select Windows or Mac.}
}
\value{
an Excel file named "KG_Shortcut" is created in the working folder
}
\description{
\code{kg_scef_tidy} This function keyboard shortcuts excel file tidy.
}
\examples{
kg_scef_tidy(xlsxFile)
}
