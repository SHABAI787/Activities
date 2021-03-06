using System;

namespace VActivities.DataBase
{
    /// <summary>
    /// Указывает что свойство является внешним ключом
    /// </summary>
    public class ExternalKeyAttribute : Attribute
    {
        /// <summary>
        /// Идентификационный набор значений
        /// </summary>
        public string Identifier { get; }

        /// <summary>
        /// Идентификационный набор значений
        /// </summary>
        public TableDB Table { get; }

        public ExternalKeyAttribute(string identifier, TableDB tableDB)
        {
            Identifier = identifier;
            Table = tableDB;
        }
    }

    /// <summary>
    /// Таблица базы данных
    /// </summary>
    public enum TableDB
    {
        Person,
        User,
        BasisСonducting,
        Purpose,
        InformationObject
    }
}
