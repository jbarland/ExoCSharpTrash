using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAnalysis
{
    internal class Analyser
    {
        public static void CountLetter(string word, out int letters, out int vowels, out int consonants)
        {
            word = word.ToLower();
            letters = 0;
            vowels = 0;
            consonants = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 97 && word[i] <= 122)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'y')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }

                    letters = vowels + consonants;
                }

            }
        }
    }
}
