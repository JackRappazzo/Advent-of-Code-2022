using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent3
{
    static class PriorityEvaluator
    {
        static Dictionary<char, int> CharValues = new Dictionary<char, int>();

        public static int GetPriority(char c)
        {
            if (CharValues.Count == 0)
                SetValues();
            return CharValues[c];

        }

        static void SetValues()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (var i = 0; i < alphabet.Length; i++)
            {
                char c = alphabet[i];
                CharValues.Add(c, i + 1);
            }
        }
    }
}
