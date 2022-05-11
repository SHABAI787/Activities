using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VActivities.DataBase
{
    /// <summary>
    /// Класс помошник. Работа с изменением данных.
    /// </summary>
    public class HelperDB
    {
        /// <summary>
        /// Шифрование строки
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="key">Ключ</param>
        /// <returns></returns>
        public static string EncryptString(string text, ushort key = ushort.MaxValue)
        {
            string result = null;
            if (!string.IsNullOrEmpty(text))
            {
                var ch = text.ToArray();
                foreach (var c in ch)
                    result += TopSecret(c, key);
            }

            return result;
        }

        /// <summary>
        /// Расшифровка строки
        /// </summary>
        /// <param name="textEncrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DecryptString(string textEncrypt, ushort key = ushort.MaxValue)
        {
            string result = null;
            if (!string.IsNullOrEmpty(textEncrypt))
            {
                var ch = textEncrypt.ToArray();
                foreach (var c in ch)
                    result += TopSecret(c, key);
            }
            return result;
        }

        private static char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey); // XOR операция
            return character;
        }

        public static string GetHashString(string s)
        {
            //переводим строку в байт-массив  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средств шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            hash = string.Concat(byteHash.Select(b => string.Format("{0:x2}", b)));

            return hash;
        }

        public static string GenerateString(int length = 10)
        {
            string res = string.Empty;
            char[] symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+№;:?><,".ToCharArray();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                res += symbols[random.Next(0, symbols.Length - 1)];
            }
            return res;
        }
    }
}
