using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCapitales
{
    internal class Quizz1
    {
        public static void Play()
        {
            string[] countries = {
                "Albanie",
                "Allemagne",
                "Andorre",
                "Autriche",
                "Belgique",
                "Belarus",
                "Bosnie-Herzégovine",
                "Bulgarie",
                "Chypre",
                "Croatie"
            };

            string[] capitals = {
                "Tirana",
                "Berlin",
                "Andorre-la-vieille",
                "Vienne",
                "Bruxelles",
                "Minsk",
                "Sarajevo",
                "Sofia",
                "Nicosie",
                "Zagreb"
            };

            int count = 0;

            string replay;

            do
            {
                //for (int i = 0; i < countries.Length; i++)
                //for (int i = 0; i < countries.Length; i += 2)
                for (int i = countries.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Quelle est la capitale du pays {countries[i]} ?");
                    string answer = Console.ReadLine();



                    if (answer == capitals[i])
                    {
                        Console.WriteLine("Bravo !\n");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"Faux ! La bonne réponse est {capitals[i]}\n");
                    }
                }

                Console.WriteLine($"Vous avez {count} bonne(s) réponse(s)");

                Console.WriteLine("Voulez-vous rejouer ?");
                replay = Console.ReadLine();
     

                if (replay == "o" || replay == "O")
                {
                  
                    Console.WriteLine("Voulez-vous rejouer ?");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Merci d'avoir joué !");
                }

            } while (replay == "o" || replay == "O");

        }
    }
}
