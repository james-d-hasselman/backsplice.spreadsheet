namespace Backsplice.Spreadsheet;

public interface ISpreadsheetFactory
{
   ISpreadsheet createSpreadsheet(string path, bool isEditable); 

   ICell createCell();

   IRow createRow();

   ISheet createSheet();

   IHeaderFooter createHeaderFooter();
}