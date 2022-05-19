﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using VActivities.Exchange;

namespace VActivities.DataBase.Tables
{
    /// <summary>
    /// Цель мероприятия
    /// </summary>
    [Serializable]
    [Table("Purpose")]
    public class Purpose : ConverXMLToObject
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
