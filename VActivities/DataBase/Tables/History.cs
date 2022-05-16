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
    /// История пользователя
    /// </summary>
    [Serializable]
    [Table("History")]
    public class History: ConverXMLToObject
    {
        public History()
        {
            DatеCreated = DateTime.Now;
        }

        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [ExternalKey("Login",TableDB.User)]
        [ReadOnly(true)]
        [DisplayName("Пользователь")]
        public virtual User User { get; set; }

        [DisplayName("Дата создания")]
        public DateTime DatеCreated { get; set; }

        [DisplayName("Наименование операции")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
