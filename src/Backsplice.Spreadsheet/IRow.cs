namespace Backsplice.Spreadsheet;

public interface IRow
{
    public List<ICell> Cells { get; set; }

    public void Append(ICell cell);
}