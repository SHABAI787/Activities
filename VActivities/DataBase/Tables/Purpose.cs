using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VActivities.Exchange;

namespace VActivities.DataBase.Tables
{
    /// <summary>
    /// Цель мероприятия
    /// </summary>
    [Serializable]
    [Table("Purpose")]
    public class Purpose : IConverXMLToObject
    {
        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        public void Conver<T>(Row row)
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


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
