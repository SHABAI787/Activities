using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VActivities.DataBase.Tables;

namespace VActivities.DataBase.Context
{
    public class VActivitiesContext : DbContext
    {
        private static string connectionString = "DbConnectionString";

        public VActivitiesContext() : base(connectionString)
        {

        }

        /// <summary>
        /// Основания для проведения
        /// </summary>
        public DbSet<BasisСonducting> BasisСonductings { get; set; }

        /// <summary>
        /// Цели
        /// </summary>
        public DbSet<Purpose> Purposes { get; set; }

        /// <summary>
        /// Информация об объектах
        /// </summary>
        public DbSet<InformationObject> InformationObjects { get; set; }

        /// <summary>
        /// Физические лица
        /// </summary>
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        /// Пользователи базы данных
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// История пользователя
        /// </summary>
        public DbSet<History> History { get; set; }

        /// <summary>
        /// Мероприятия
        /// </summary>
        public DbSet<Activities> Activities { get; set; }
    }
}
