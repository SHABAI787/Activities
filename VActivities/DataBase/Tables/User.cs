using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VActivities.Exchange;

namespace VActivities.DataBase.Tables
{
    /// <summary>
    /// Пользователь базы данных
    /// </summary>
    [Serializable]
    [Table("User")]
    public class User: ConverXMLToObject
    {
        public User()
        {
            DatеCreated = DateTime.Now;
        }

        [Key]
        [ReadOnly(true)]
        [DisplayName("Логин")]
        public string Login { get; set; }

        [ReadOnly(true)]
        [DisplayName("Пароль")]
        public string Password { get; set; }

        [DisplayName("Активность")]
        public bool Active { get; set; }

        [ExternalKey("LongFIO", TableDB.Person)]
        [ReadOnly(true)]
        [DisplayName("Физ. лицо")]
        public virtual Person Person { get; set; }

        [ReadOnly(true)]
        [DisplayName("Дата создания")]
        public DateTime DatеCreated { get; set; }

        [ReadOnly(true)]
        [DisplayName("Дата обновления данных")]
        public DateTime? DatеUpdated { get; set; }

        [Browsable(false)]
        [DisplayName("Данные")]
        public string Data { get; set; }

        public override string ToString()
        {
            return $"{Login}";
        }

        /// <summary>
        /// Установить пароль используя шифрование\хеширование
        /// </summary>
        /// <param name="password"></param>
        public void SetCryptoPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                Password = null;
            }
            else
            {
                string data = CryptoDB.GenerateString();
                Data = CryptoDB.EncryptString(data);
                Password = CryptoDB.GetHashString($"{password}{data}");
            }
        }

        /// <summary>
        /// Сравнить пароль. Выполнять при использовании SetCryptoPassword
        /// </summary>
        /// <param name="passwordCompare">Пароль для сравнения</param>
        /// <returns>Возвращает True если пароли сходятся</returns>
        public bool ComparePassword(string passwordCompare)
        {
            if (string.IsNullOrEmpty(Password))
            {
                return string.IsNullOrEmpty(passwordCompare);
            }
            else
            {
                string data = CryptoDB.DecryptString(Data);
                return CryptoDB.GetHashString($"{passwordCompare}{data}") == Password;
            }
        }
    }
}
