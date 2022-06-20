using DateTimeHelper;

DateTime today = DateTime.Today;

Console.WriteLine($"Le dernier jour du mois en cours est {today.GetLastDayOfMonth().ToString("dddd")}");
