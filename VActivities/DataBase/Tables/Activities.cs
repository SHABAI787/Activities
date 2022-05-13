﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VActivities.DataBase.Tables
{
    /// <summary>
    /// Мероприятие
    /// </summary>
    [Serializable]
    [Table("Activities")]
    public class Activities
    {

        public Activities()
        {
            DatеCreated = DateTime.Now;
        }

        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Номер мероприятия")]
        public int Num { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }
        
        [ReadOnly(true)]
        [DisplayName("Основание для проведения")]
        public virtual BasisСonducting BasisСonducting { get; set; }

        [ReadOnly(true)]
        [DisplayName("Цель")]
        public virtual Purpose Purpose { get; set; }

        [ReadOnly(true)]
        [DisplayName("Начало проведения")]
        public DateTime? DateIn { get; set; }

        [ReadOnly(true)]
        [DisplayName("Окончание проведения")]
        public DateTime? DateOut { get; set; }

        [ReadOnly(true)]
        [DisplayName("Объект")]
        public virtual InformationObject InformationObject { get; set; }

        [DisplayName("Подразделение/Заказчик")]
        public string Customer { get; set; }

        [ReadOnly(true)]
        [DisplayName("Ответственный")]
        public virtual Person Responsible{ get; set; }

        [ReadOnly(true)]
        [DisplayName("Исполнитель")]
        public virtual Person Executor { get; set; }

        [DisplayName("Рег.номер поступившего документа")]
        public string RegNum { get; set; }

        [DisplayName("Рег.номер входящего документа")]
        public string RegNumIn { get; set; }

        [DisplayName("Результат")]
        public string Result { get; set; }

        [DisplayName("Обратная связь")]
        public string Feedback { get; set; }

        [ReadOnly(true)]
        [DisplayName("Дата создания")]
        public DateTime DatеCreated { get; set; }

        public override string ToString()
        {
            return $"{Num}, {Name}";
        }
    }
}
