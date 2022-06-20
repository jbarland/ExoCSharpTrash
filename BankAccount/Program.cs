using BankAccount;

Account account1 = new Account(444444, "Dom", 888888);
Account account2 = account1;

Console.WriteLine(account1);
Console.WriteLine();
Console.WriteLine(account2);

account2.CB.Number = 555555;
account2.Number = 6666666;

Console.WriteLine(account1);
Console.WriteLine();
Console.WriteLine(account2);

Account account3 = account1.GetCopy();

account3.CB.Number = 3333333;
account3.Number = 33333000;

Console.WriteLine("1 :" + account1);
Console.WriteLine();
Console.WriteLine("3 :" + account3);

account1.Balance = 100;

AccountWithNotifClient testnotif = new AccountWithNotifClient(account1);

testnotif.Debit(150);

