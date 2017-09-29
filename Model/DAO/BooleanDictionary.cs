using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class BooleanDictionary
    {
        private static BooleanDictionary booleanDictionaryObj;
        private static Dictionary<int, string> booleanDictionary;

        public BooleanDictionary()
        {
            booleanDictionary = new Dictionary<int, string>();

            booleanDictionary.Add(0, "Não");
            booleanDictionary.Add(1, "Sim");
        }

        public static Dictionary<int, string> BooleanList
        {
            get
            {
                if (booleanDictionary == null)
                {
                    booleanDictionaryObj = new BooleanDictionary();
                }
                return booleanDictionary;
            }
        }
    }    
}