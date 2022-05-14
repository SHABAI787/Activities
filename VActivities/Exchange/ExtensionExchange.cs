using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VActivities.View.Forms;

namespace VActivities.Exchange
{
    public static class ExtensionExchange
    {
        public static void ExportToXML(this DataGridView dataGridView, string file = null)
        {
            DataExportImport dataExport = new DataExportImport();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.XML|*.XML";

            if (string.IsNullOrEmpty(file) && saveFileDialog.ShowDialog() == DialogResult.OK)
                file = saveFileDialog.FileName;

            FormExportOptions formExportOptions = new FormExportOptions();
            if (!string.IsNullOrEmpty(file) && formExportOptions.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<DataGridViewRow> rows = formExportOptions.AllRows ? dataGridView.Rows.Cast<DataGridViewRow>()  : dataGridView.SelectedRows.Cast<DataGridViewRow>();

                foreach (DataGridViewRow row in rows)
                {
                    Row dRow = new Row();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        Cell dCell = new Cell();
                        dCell.Name = cell.OwningColumn.Name;
                        dCell.Value = cell.Value == null ? "" : cell.Value.ToString();
                        dRow.Cells.Add(dCell);
                    }
                    dataExport.Rows.Add(dRow);
                }

                dataExport.SaveXML(file);
            }
        }

        public static void SaveXML<T>(this T obj, string pathSave)
        {
            ExchangeXML.SerializeXML<T>(pathSave, obj);
        }
    }

   
}
