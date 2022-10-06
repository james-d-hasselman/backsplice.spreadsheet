using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasselman.Backsplice.Spreadsheet
{
    public interface ISpreadsheetDocument
    {
        public void Save();
        public void SaveAs(string path);
        public void Close();
        public IReadOnlyList<IWorksheet> Sheets { get; }
        public void AddSheet(IWorksheet worksheet);
        public void RemoveSheet(IWorksheet worksheet);
    }
}
