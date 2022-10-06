using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasselman.Backsplice.Spreadsheet
{
    public interface IWorksheet
    {
        public string LeftHeader { get; set; }
        public string RightHeader { get; set; }

        public IList<IRow> Rows { get; }
        public IList<IColumn> Columns { get; }
        public IWorksheet DeepCopy();
    }
}
