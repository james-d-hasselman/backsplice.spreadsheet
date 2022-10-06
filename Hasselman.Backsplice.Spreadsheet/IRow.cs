// SPDX-FileCopyrightText: 2022 James D. Hasselman <james.d.hasselman@gmail.com>
// SPDX-License-Identifier: GPL-3.0-or-later

namespace Hasselman.Backsplice.Spreadsheet
{
    public interface IRow
    {
        double Height { get; set; }
        public IList<ICell> Cells { get; set; }
    }
}
