using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface IAccount
    {
        decimal Balance { get; }
        void Debit(decimal amount);
    }
    public class Account : IAccount
    {
        public long Number { get; set; }
        public string Holder { get; set; }
        public Card CB { get; set; }

        public decimal Balance { get; set; }

        public Account(long number, string holder, long cardNumber)
        {
            Number = number;
            Holder = holder;
            CB = new Card(cardNumber);
        }

        public override string ToString()
        {
            return $"Compte N°{Number} de {Holder} associé à la carte N°{CB.Number}";
        }

        public Account GetCopy()
        {
            Account cloneAccount = (Account)this.MemberwiseClone(); // clone que les prop de type simple
            cloneAccount.CB = new Card(this.CB.Number); // pour bien cloner aussi la carte
         
            return cloneAccount;
        }

        public void Debit(decimal amount)
        {
            Balance -= amount;
        }
    }

    public abstract class AccountWithNotif : IAccount
    {
        private IAccount _account;

        protected AccountWithNotif(IAccount account)
        {
            _account = account;
        }

        public decimal Balance { get; private set; }

        public virtual void Debit(decimal amount)
        {
            Balance -= amount;
        }
    }

    public class AccountWithNotifClient : AccountWithNotif, IAccount
    {
        public AccountWithNotifClient(IAccount account) : base(account)
        {
        }

        public override void Debit(decimal amount)
        {
            base.Debit(amount);
            if (Balance < 0)
            {
                Console.WriteLine("Votre compte est débiteur");
            }
        }
    }
}
