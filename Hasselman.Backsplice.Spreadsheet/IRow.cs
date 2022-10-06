using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasselman.Backsplice.Spreadsheet
{
    public interface IRow
    {
        double Height { get; set; }
        public IList<ICell> Cells { get; set; }
    }
}
