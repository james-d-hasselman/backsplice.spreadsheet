namespace Backsplice.Spreadsheet;

public interface ISheet
{
    public string Name { get; set; }

    public List<IRow> Rows { get; set; }

    public IHeaderFooter HeaderFooter { get; set; }

    public ISheet DeepCopy();
}