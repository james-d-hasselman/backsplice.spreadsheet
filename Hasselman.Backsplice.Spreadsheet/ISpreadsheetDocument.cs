// SPDX-FileCopyrightText: 2022 James D. Hasselman <james.d.hasselman@gmail.com>
// SPDX-License-Identifier: GPL-3.0-or-later

namespace Hasselman.Backsplice.Spreadsheet
{
    public enum SpreadsheetDocumentMode
    {
        ReadOnly,
        ReadWrite
    }
    public interface ISpreadsheetDocument
   {
        public void Open(string filePath, SpreadsheetDocumentMode mode);
        public void Save();
        public void SaveAs(string path);
        public void Close();
        public IReadOnlyList<IWorksheet> Sheets { get; }
        public void AddSheet(IWorksheet worksheet);
        public void RemoveSheet(IWorksheet worksheet);
    }
}
