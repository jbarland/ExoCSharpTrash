using DrinkDispenser;
Console.WriteLine("Veuillez insérez votre carte");
Console.ReadKey();
Random random = new Random();
decimal balance = Math.Round(Convert.ToDecimal((random.NextDouble)), 2);
Console.WriteLine($"Vous avez {balance} euros disponible");

Console.WriteLine("Choisisser la quantité de sucre (max 10g)");
int sugarAmout = int.Parse(Console.ReadLine());

Console.WriteLine("Choisissez le numéro de votre boisson :\n1.Café\n2.Chocolat\n3.Soupe");
int drinkNb = int.Parse(Console.ReadLine());
Drinks drink = Drinks.Cofee;

if (drinkNb == 2)
{
    drink = Drinks.Chocolate;
}
else if (drinkNb == 3)
{
    drink = Drinks.Soup;
}

Dispenser myCmd = new Dispenser(drink, balance, sugarAmout);

Console.WriteLine(myCmd.ServeDrink());
