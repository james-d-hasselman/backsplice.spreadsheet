// SPDX-FileCopyrightText: 2022 James D. Hasselman <james.d.hasselman@gmail.com>
// SPDX-License-Identifier: GPL-3.0-or-later

namespace Backsplice.Spreadsheet;

public interface IWorksheet
{
    public string LeftHeader { get; set; }
    public string RightHeader { get; set; }

    public IList<IRow> Rows { get; }
    public IList<IColumn> Columns { get; }
    public IWorksheet DeepCopy();
}
