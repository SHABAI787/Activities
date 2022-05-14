using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VActivities.Exchange
{
    /// <summary>
    /// Работа с XML документом. Сериализация и Десериализация.
    /// </summary>
    public static class ExchangeXML
    {
        /// <summary>
        /// Сериализация XML файла
        /// </summary>
        /// <param name="file">Путь сохранения файла</param>
        /// <param name="obj">Объект сохранения</param>
        /// <returns></returns>
        public static void SerializeXML<T>(string file, T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(file, FileMode.Create))
            {
                formatter.Serialize(stream, obj);
            }
        }

        /// <summary>
        /// Десериализация XML файла
        /// </summary>
        /// <param name="patchFile">Путь загрузки файла</param>
        /// <param name="fileMode">Указывает, каким образом операционная система должна открыть файл</param>
        /// <returns></returns>
        public static T DeserializeXML<T>(string patchFile, FileMode fileMode = FileMode.OpenOrCreate)
        {
            T result = default(T);
            using (FileStream stream = new FileStream(patchFile, fileMode))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                result = (T)formatter.Deserialize(stream);
            }
            return result;
        }

        /// <summary>
        /// Сохранение XML документа
        /// </summary>
        /// <typeparam name="T">Тип данных объекта</typeparam>
        /// <param name="obj">Объект для сохранения</param>
        /// <param name="pathSave">Путь сохранения</param>
        public static void SaveXML<T>(T obj, string pathSave)
        {
            ExchangeXML.SerializeXML<T>(pathSave, obj);
        }

        /// <summary>
        /// Загрузка XML документа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pathLoad"></param>
        /// <returns></returns>
        public static T LoadXML<T>(string pathLoad)
        {
            T res = default(T);
            try
            {
                if (File.Exists(pathLoad))
                    res = ExchangeXML.DeserializeXML<T>(pathLoad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return res;
        }
    }
}
