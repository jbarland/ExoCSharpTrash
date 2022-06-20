using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCapitales
{
    internal class Quizz2
    {
        static string[] countries = {
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

        static string[] capitals = {
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

        public static bool AskCapital(int nbQuestion)
        {
            Console.WriteLine($"Quelle est la capitale du pays {countries[nbQuestion]} ?");
            string answer = Console.ReadLine();
            bool goodAnswer;

            if (answer == capitals[nbQuestion])
            {
                Console.WriteLine("Bravo !\n");
                goodAnswer = true;
            }
            else
            {
                Console.WriteLine($"Faux ! La bonne réponse est {capitals[nbQuestion]}\n");
                goodAnswer = false;
            }

            return goodAnswer;
        }


        public static void Play()
        {
            bool answerReplay;
            do
            {
                for (int i = 0; i < countries.Length; i++)
                {
                    bool goodAnswer = AskCapital(i);
                }
                answerReplay = Replay();
            } while (answerReplay == true);



        }

        public static bool Replay()
        {
            Console.WriteLine("Voulez-vous rejouer ?");
            string replay = Console.ReadLine();
            bool answer;


            if (replay == "o" || replay == "O")
            {

                Console.WriteLine("Voulez-vous rejouer ?");
                Console.Clear();
                answer = true;
            }
            else
            {
                Console.WriteLine("Merci d'avoir joué !");
                answer = false;
            }

            return answer;
        }
    };
}
