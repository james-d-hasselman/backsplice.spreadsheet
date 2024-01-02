namespace Backsplice.Spreadsheet;

public interface IHeaderFooter
{
    public bool DifferentFirst { get; set; }
    public bool DifferentOddEven { get; set; }
    public string FirstFooter { get; set; }
    public string FirstHeader { get; set; }
    public string OddHeader { get; set; }
    public string EvenHeader { get; set; }
    public string OddFooter { get; set; }
    public string EvenFooter { get; set; }
    public bool AlignWithMargins { get; set; }
    public bool ScaleWithDoc { get; set; }
}