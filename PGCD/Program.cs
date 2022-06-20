using PGCD;

Console.WriteLine("entrer un 1er nombre");

int p = int.Parse(Console.ReadLine());

Console.WriteLine("entrer un 2ème nombre");

int q = int.Parse(Console.ReadLine());

Console.WriteLine($"Le PGCD de {p} et {q} est {Calcul.CalculPGCD(p, q)}");

