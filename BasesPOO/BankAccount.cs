using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesPOO
{
    public class BankAccount
    {
        private long _accountNumber;
        private bool _overdrawn;

        //private DateTime _createdAt;
        private DateTime _closeAt;

        //private Decimal _balance;

        //Constructeur
        public BankAccount(DateTime createdAt)
        {
            //_createdAt = createdAt;
            CreatedAt = createdAt;
        }

        /*

        public Decimal Balance
        {
            get { return _balance; }

        }
        */

        //OU

        public Decimal Balance { get; private set; }

        //public DateTime CreatedAt { get { return _createdAt; } }
        //OU
        public DateTime CreatedAt
        {
            get; private set;
        }

        private int CalculateSeniority()
        {
            TimeSpan ts = DateTime.Today - CreatedAt;
            return ts.Days;
        }

        

        public void Credit(Decimal amount)
        {
            //_balance += amount;
            Balance += amount;
        }


        //SURCHARGE
        public void Close()
        {
            //_closeAt = DateTime.Today;
            //OU
            Close(DateTime.Today);
        }

        public void Close(DateTime closeAt)
        {
            _closeAt = closeAt;
        }
        /////////////////

    }


}
