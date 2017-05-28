using System.Collections.Generic;

namespace Model.DAO
{
    public class SexDictionary
    {
        private static SexDictionary SexDictionaryObj;
        private static Dictionary<short, string> sexDictionary;

        public SexDictionary()
        {
            sexDictionary = new Dictionary<int, string>();
            sexDictionary.Add((short)Sex.FEMALE, "Feminino");
            sexDictionary.Add((short)Sex.MALE, "Masculino");
            sexDictionary.Add((short)Sex.INDETERMINATE, "Indeterminado");
        }

        public static Dictionary<short, string> SexList
        {
            get
            {
                if (sexDictionary == null)
                {
                    SexDictionaryObj = new SexDictionary();
                }
                return sexDictionary;
            }
        }
    }
}
