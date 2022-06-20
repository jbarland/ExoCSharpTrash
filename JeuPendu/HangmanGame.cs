using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPendu
{
    public enum GameStates { InProgress, Win, Lose }
    public class HangmanGame
    {
        public string Word { get; }
        public string StateWord { get; private set; }
        public GameStates GameStates { get; set; }
        public int NbErrors { get; private set; }
        public string _hangDraw;

        public HangmanGame(string word)
        {
            this.Word = word;
            this.GameStates = GameStates.InProgress;
            this.StateWord = new string('-', Word.Length);
        }

        public static void CheckWord(string word)
        {
            word = word.ToLower();
            word = word.Trim();

            if (word.Length < 3 || word.Length > 25)
            {
                throw new ArgumentException("Le mot doit contenir entre 3 et 25 lettres");
            }

            foreach (char c in word)
            {
                if (!(c >= 97 && c <= 122))
                {

                    throw new ArgumentException("le mot doit comporter que des lettres sans accent");
                }

            }
        }

        public void WordState(char tryLetter)
        {
            List<char> answerCharList = new List<char>();
            List<char> stateCharList = new List<char>();


            foreach (var c in StateWord)
            {
                stateCharList.Add(c);
            }
            foreach (var c in Word)
            {
                answerCharList.Add(c);
            }

            int count = answerCharList.Count;

            for (int i = 0; i < count; i++)
            {
                if (tryLetter == answerCharList[i])
                {
                    stateCharList[i] = answerCharList[i];

                }
            }

            string NewStateWord = new string(stateCharList.ToArray());

            if (NewStateWord == StateWord)
            {
                NbErrors++;
            }

            StateWord = NewStateWord;

            if (StateWord == Word)
            {
                GameStates = GameStates.Win;
            }
            if (NbErrors == 2)
            {
                GameStates = GameStates.Lose;
            }
        }

        public string HangDraw()
        {

            string res;
            switch (NbErrors)
            {
                case 1:
                    res = @"





   ____";
                    break;
                case 2:
                    res = @"

   |
   |   
   |  
   |   
   |____";
                    break;
                case 3:
                    res = @"
   ____
   |
   |   
   |  
   |   
   |____";
                    break;
                case 4:
                    res = @"
   ____
   |/  
   |   
   |  
   |   
   |____";
                    break;
                case 5:
                    res = @"
   ____
   |/  |
   |   
   |  
   |   
   |____";
                    break;
                case 6:
                    res = @"
   ____
   |/  |
   |   o
   |  
   |   
   |____";
                    break;
                case 7:
                    res = @"
   ____
   |/  |
   |   o
   |   |
   |   
   |____";
                    break;
                case 8:
                    res = @"
   ____
   |/  |
   |   o
   |  /|
   |   
   |____";
                    break;
                case 9:
                    res = @"
   ____
   |/  |
   |   o
   |  /|\
   |   
   |____";
                    break;
                case 10:
                    res = @"
   ____
   |/  |
   |   o
   |  /|\
   |  / 
   |____";
                    break;
                case 11:
                    res = @"
   ____
   |/  |
   |  ~o~
   |  /|\
   |  / \
   |____";
                    break;
                default:
                    res = @"





   ";
                    break;
            }
            return res;

        }
    }


    

}
