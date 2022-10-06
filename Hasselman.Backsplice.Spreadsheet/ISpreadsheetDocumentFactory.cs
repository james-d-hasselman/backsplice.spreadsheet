// SPDX-FileCopyrightText: 2022 James D. Hasselman <james.d.hasselman@gmail.com>
// SPDX-License-Identifier: GPL-3.0-or-later

namespace Hasselman.Backsplice.Spreadsheet
{
    public interface ISpreadsheetDocumentFactory
    {
        ISpreadsheetDocument Create(string filePath, bool isReadOnly);
    }
}
