using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VActivities.Exchange
{
    /// <summary>
    /// Преобразование XML документа в объект T
    /// </summary>
    public interface IConverXMLToObject
    {
        void Conver<T>(Row row);
    }
}
