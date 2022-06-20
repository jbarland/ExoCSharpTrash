using SignesZodiaque;

Zodiaque.Signes signe;

for (signe = Zodiaque.Signes.Bélier; signe <= Zodiaque.Signes.Poisson; signe++)
{
    Zodiaque.DatePourSigne(signe, out DateTime startDate, out DateTime endDate);
    Console.WriteLine($"tu es du signe {signe}" +
        $" si tu es né(e) entre le {startDate.Day} {startDate.Month} et le  {endDate.Day} {endDate.Month}");

}

Console.WriteLine("date de naissance ?");

DateTime birthdate = DateTime.Parse(Console.ReadLine());

signe = Zodiaque.SignePourDate(birthdate);

Console.WriteLine($"ton signe du zodiaque est {signe}");