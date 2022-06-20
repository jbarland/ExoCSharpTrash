using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    internal class TextAnalysis
    {
        //compter nb de mot
        public static int countWord(string sentence)
        {
            int nbWord = 1;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' || sentence[i] == '\'') nbWord++;
            }

            return nbWord;
        }
    }
}
