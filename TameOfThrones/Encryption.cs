using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TameOfThrones
{
    static class Encryption
    {
        public static string SeasarCipher(string text, int index)
        {
            string decryptText = new string(text.Select(ch => (char)((ch - index < 65) ? (91 - index - ch + 65) : (ch - index))).ToArray());
            return decryptText;
        }
        public static bool AlphabetCountCheck(string emblem, string msg)
        {
            int common= msg.GroupBy(c => c)
            .Join(emblem.GroupBy(c => c),
            g => g.Key,
            g => g.Key,
            (lg, rg) => lg.Zip(rg, (l, r) => l).Count()).Sum();
            return common==emblem.Length;
        }
    }
}
