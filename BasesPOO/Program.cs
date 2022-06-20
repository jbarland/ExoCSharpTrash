using BasesPOO;

BankAccount myAccount = new BankAccount(DateTime.Today);

myAccount.Credit(57m);

Console.WriteLine($"solde du compte: {myAccount.Balance}€");
