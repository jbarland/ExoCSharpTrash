using Meteo;
using System.Globalization;
using System.Text;
using System.Text.Json;

Console.OutputEncoding = Encoding.UTF8;

MonthlyStatements test = new MonthlyStatements(@"31/01/2007	6,2	10,2	28,0	46,0");
Console.WriteLine();

Console.WriteLine(test.Sunshine);

var list = DAL.GetMonthlyStatements();


Console.WriteLine(MonthlyStatements._headingArray);

foreach (var statement in list)
{

    Console.WriteLine(statement);//.ToString());
}

decimal gain = 148m;

TimeSpan durée = new TimeSpan(2, 25, 46);

DateTime dateDeb = new DateTime(2016, 12, 21);

decimal total = 1234;



string s = string.Format(CultureInfo.GetCultureInfo("en-US"),
    "Hier, Bryan a gagné {0:C2} à la roulette en {1:%h} heures {1:mm} minutes.\n"
    + "Durant l'hiver, c'est à dire depuis le {2:dd MMM yyyy}, il a gagné {3:C0}.",
    gain, durée, dateDeb, total);

Console.WriteLine();
Console.WriteLine(s);


// Construction du texte ligne à ligne en mémoire
StringWriter writer = new StringWriter();

writer.WriteLine(MonthlyStatements._headingArray);

foreach (var statement in list)
{
    writer.WriteLine(statement);
}

// Ecriture du texte dans un fichier
File.WriteAllText("TableauReleves.txt", writer.ToString());


var options = new JsonSerializerOptions { WriteIndented = true };

// Sérialisation au format JSON
string jsonString = JsonSerializer.Serialize(list, options);

// Écriture du texte dans un fichier
File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + "\\relevés.json", jsonString);

Console.Clear();

Stats stats = new Stats(list);

Console.WriteLine("Précipitations année 2017: " + stats.GetPrecipitationsYear(2017));

Console.WriteLine();

Console.WriteLine("Mois le + chaud: " + stats.StatementTempMax);

Console.WriteLine();

Console.WriteLine("EnsoleillementMoyenJuillet :" + stats.GetAverageSunshineForJuly());

Console.WriteLine();

Console.WriteLine("Nombre de mois chaud :" + stats.GetNbHotMonths());

foreach (var test2 in stats.GetAveragePrecByYear())
{
    Console.WriteLine(test2);
}