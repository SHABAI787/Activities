using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using VActivities.Exchange;

namespace VActivities.DataBase.Tables
{
    /// <summary>
    /// Физическое лицо
    /// </summary>
    [Serializable]
    [Table("Person")]
    public class Person : ConverXMLToObject
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

        [DisplayName("Краткое ФИО")]
        [NotMapped]
        public string ShortFIO
        {
            get { return $"{Surname} {(string.IsNullOrEmpty(Name) ? "" : Name.ElementAt(0).ToString())}.{(string.IsNullOrEmpty(MiddleName) ? "" : MiddleName.ElementAt(0).ToString())}."; }
        }

        [DisplayName("ФИО")]
        [NotMapped]
        public string LongFIO
        {
            get { return $"{Surname} {Name} {MiddleName}"; }
        }

        public override string ToString()
        {
            return ShortFIO;
        }
    }
}
