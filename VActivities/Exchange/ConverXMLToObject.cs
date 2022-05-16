using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VActivities.Exchange
{
    /// <summary>
    /// Преобразование XML документа в объект T
    /// </summary>
    public abstract class ConverXMLToObject
    {
        public virtual void Conver<T>(Row row)
        {
            foreach (var cell in row.Cells)
            {
                DateTime dateTime = DateTime.MinValue;

                if (cell.Value != null && DateTime.TryParse(cell.Value, out dateTime))
                    this.GetType().GetProperty(cell.Name).SetValue(this, dateTime);
                else
                    this.GetType().GetProperty(cell.Name).SetValue(this, cell.Value);
            }
        }
    }
}
