using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasselman.Backsplice.Spreadsheet
{
    public interface ISpreadsheetDocumentFactory
    {
        ISpreadsheetDocument Create(string filePath, bool isReadOnly);
    }
}
