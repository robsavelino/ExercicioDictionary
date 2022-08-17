using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDictionary
{
    public class Services
    {
        public static void ResetDictionary (Dictionary<char, int> dictionary)
        {
            dictionary.Clear ();
            dictionary.Add('a', 0);
            dictionary.Add('e', 0);
            dictionary.Add('i', 0);
            dictionary.Add('o', 0);
            dictionary.Add('u', 0);
        }

        public static void GetVowels(Dictionary<char, int> dictionary, string text)
        {
            foreach (char c in text)
            {
                if (dictionary.ContainsKey(c))
                    dictionary[c]++;
            }
        }
    }
}
