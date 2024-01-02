namespace Backsplice.Spreadsheet;

public interface ISpreadsheet
{
    public List<ISheet> Sheets {get; set;}

    public void Save();
}