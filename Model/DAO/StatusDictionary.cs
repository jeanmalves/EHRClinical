using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class StatusDictionary
    {
        private static StatusDictionary statusDictionaryObj;
        private static Dictionary<int, string> statusDictionary;

        public StatusDictionary()
        {
            statusDictionary = new Dictionary<int, string>();

            statusDictionary.Add(0, "Inativo");
            statusDictionary.Add(1, "Ativo");
        }

        public static Dictionary<int, string> StatusList
        {
            get
            {
                if (statusDictionary == null)
                {
                    statusDictionaryObj = new StatusDictionary();
                }
                return statusDictionary;
            }
        }
    }
}
