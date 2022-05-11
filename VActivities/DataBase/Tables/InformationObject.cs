using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VActivities.DataBase.Tables
{
    /// <summary>
    /// Информация об объекте
    /// </summary>
    [Serializable]
    [Table("InformationObject")]
    public class InformationObject
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

        [DisplayName("Дата создания")]
        public DateTime DatеCreated { get; set; }

        [DisplayName("Дата обновления данных")]
        public DateTime? DatеUpdated { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Num}, {IMEI}";
        }
    }
}

