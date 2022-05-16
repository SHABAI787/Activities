﻿using System;
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
    /// Основание для проведения
    /// </summary>
    [Serializable]
    [Table("BasisСonducting")]
    public class BasisСonducting:ConverXMLToObject
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
