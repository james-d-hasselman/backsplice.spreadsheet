namespace Backsplice.Spreadsheet;

public interface ISpreadsheet : IDisposable
{
    public List<ISheet> Sheets {get; set;}

    public void Save();
}