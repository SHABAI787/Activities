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
    /// Информация об объекте
    /// </summary>
    [Serializable]
    [Table("InformationObject")]
    public class InformationObject: IConverXMLToObject
    {
        public InformationObject()
        {
            DatеCreated = DateTime.Now;
        }

        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Номер")]
        public string Num { get; set; }

        [DisplayName("IMEI")]
        public string IMEI { get; set; }

        [DisplayName("IMSI")]
        public string IMSI { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [ReadOnly(true)]
        [DisplayName("Дата создания")]
        public DateTime DatеCreated { get; set; }

        [ReadOnly(true)]
        [DisplayName("Дата обновления данных")]
        public DateTime? DatеUpdated { get; set; }

        public void Conver<T>(Row row)
        {
            foreach (var cell in row.Cells)
            {
                DateTime dateTime = DateTime.MinValue;

                if(cell.Value != null && DateTime.TryParse(cell.Value, out dateTime))
                    this.GetType().GetProperty(cell.Name).SetValue(this, dateTime);
                else
                    this.GetType().GetProperty(cell.Name).SetValue(this, cell.Value);
            }
        }

        public override string ToString()
        {
            return $"{Num}, {IMEI}";
        }
    }
}

