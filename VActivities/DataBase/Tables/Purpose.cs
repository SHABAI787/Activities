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
    /// Цель мероприятия
    /// </summary>
    [Serializable]
    [Table("Purpose")]
    public class Purpose
    {
        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
