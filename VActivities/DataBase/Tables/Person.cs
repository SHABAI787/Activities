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
    /// Физическое лицо
    /// </summary>
    [Serializable]
    [Table("Person")]
    public class Person
    {
        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }
    }
}
