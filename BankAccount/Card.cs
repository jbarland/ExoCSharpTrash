using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Card
    {
        public long Number { get; set; }

        public Card(long number)
        {
            Number = number;
        }
    }
}
