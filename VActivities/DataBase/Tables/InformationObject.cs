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
    public class InformationObject: ConverXMLToObject
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

        [Browsable(false)]
        [DisplayName("Текстовое представление")]
        [NotMapped]
        public string LongText
        {
            get { return string.Join(", ", new string[] { Num, IMEI, IMSI }); }
        }

        public override string ToString()
        {
            return string.Join(", ", new string[] { Num, IMEI});
        }
    }
}

