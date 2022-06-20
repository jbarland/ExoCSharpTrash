using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    public enum Combinations { none=0, first24=1, last24=2, red=4, black=8, odd=16, even=32}
    public class Roulette
    {
        private Random _random;
        private Throw _throw;

        
    }

    public class Bet
    {

    }

    public class Throw
    {
        public int Num { get; }
        public Combinations Combination { get; }

        public void TheThrow()
        {

        }

    }

    public class Game
    {
    }
}
