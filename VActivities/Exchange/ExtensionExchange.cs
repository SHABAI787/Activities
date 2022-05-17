using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VActivities.View.Forms;
using VActivities.DataBase;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;

namespace VActivities.Exchange
{
    public static class ExtensionExchange
    {
        /// <summary>
        /// Сохранение XML документа
        /// </summary>
        /// <typeparam name="T">Тип данных объекта</typeparam>
        /// <param name="obj">Объект для сохранения</param>
        /// <param name="pathSave">Путь сохранения</param>
        public static void SaveXML<T>(this T obj, string pathSave)
        {
            ExchangeXML.SerializeXML<T>(pathSave, obj);
        }

        /// <summary>
        /// Экспорт данных в формате XML
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="file"></param>
        public static void ExportToXML(this DataGridView dataGridView, string file = null)
        {
            try
            {
                DataExportImport dataExport = new DataExportImport();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "*.XML|*.XML";

                if (string.IsNullOrEmpty(file) && saveFileDialog.ShowDialog() == DialogResult.OK)
                    file = saveFileDialog.FileName;

                FormExportOptions formExportOptions = new FormExportOptions();
                if (!string.IsNullOrEmpty(file) && formExportOptions.ShowDialog() == DialogResult.OK)
                {
                    IEnumerable<DataGridViewRow> rows = formExportOptions.AllRows ? dataGridView.Rows.Cast<DataGridViewRow>() : dataGridView.SelectedRows.Cast<DataGridViewRow>();

                    foreach (DataGridViewRow row in rows)
                    {
                        Row dRow = new Row();

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            Cell dCell = new Cell();
                            dCell.Name = cell.OwningColumn.Name;
                            dCell.Value = cell.Value == null ? "" : cell.Value.ToString();

                            PropertyInfo prInf = row.DataBoundItem.GetType().GetProperty(cell.OwningColumn.Name);
                            ExternalKeyAttribute attribute = (ExternalKeyAttribute)prInf.GetCustomAttribute(typeof(ExternalKeyAttribute));
                            if (attribute != null)
                            {
                                object value = prInf.GetValue(row.DataBoundItem);
                                if(value != null)
                                {
                                    object value2 = value.GetType().GetProperty(attribute.Identifier).GetValue(value);
                                    dCell.Value = value2 == null ? "" : value2.ToString();
                                }
                            }


                            dRow.Cells.Add(dCell);
                        }

                        if(row.DataBoundItem is User)
                        {
                            User user = row.DataBoundItem as User;
                            Cell dCell = new Cell();
                            dCell.Name = "Data";
                            dCell.Value = user.Data == null ? "" : user.Data.ToString();
                            dRow.Cells.Add(dCell);
                        }
                        dataExport.Rows.Add(dRow);
                    }

                    dataExport.SaveXML(file);
                }
            }
            catch (Exception ex)
            {
                FormBase.ShowError(ex.Message);
            }
        }


        /// <summary>
        /// Импорт данных в формате XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bindingSource"></param>
        public static void ImportFromXML<T>(this BindingSource bindingSource, VActivitiesContext context = null) where T: ConverXMLToObject
        {
            try
            {
                bool clearDataGridView = MessageBox.Show("Очистить старый список?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                                == DialogResult.Yes ? true : false;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "*.XML|*.XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataExportImport dataExport = ExchangeXML.LoadXML<DataExportImport>(openFileDialog.FileName);

                    if (dataExport != null)
                    {
                        if (clearDataGridView)
                            bindingSource.Clear();

                        foreach (var dRow in dataExport.Rows)
                        {
                            T itemNew = (T)bindingSource.AddNew();
                            if(context == null)
                                itemNew.Conver<T>(dRow);
                            else
                                itemNew.Conver<T>(dRow, context);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormBase.ShowError(ex.Message);
            }
        }
    }

   
}
