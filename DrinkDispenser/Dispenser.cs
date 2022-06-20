using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkDispenser
{
    public enum Drinks { Cofee, Chocolate, Soup };
    public class Dispenser
    {
        public Drinks Drink { get; }
        public int Sugar { get; private set; }
        public decimal CardBalance { get; private set; }

        public Dispenser(Drinks drink, decimal cardBalance, int sugar = 3 )
        {
            Drink = drink;
            Sugar = sugar;
            CardBalance = cardBalance;
        }

        public string ServeDrink()
        {
            if (Sugar > 10)
            {
                Sugar = 10;
            }

            string sugarMessage = $" avec {Sugar}g de sucre";
            //decimal price = 0;
            if (Drink == Drinks.Cofee)
            {
                CardBalance -= 0.8m;
            }
            else if (Drink == Drinks.Chocolate)
            {
                CardBalance -= 0.75m;
            }
            else if (Drink == Drinks.Soup)
            {
                CardBalance -= 0.1m;
                Sugar = 0;
                sugarMessage = string.Empty;
            }

            if (CardBalance >= 0)
            {
                return Drink + sugarMessage;
            }
            else
            {
                return "Solde insuffisant !";
            }

            

        }
    }
}
