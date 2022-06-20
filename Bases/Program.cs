//Affichage + retour chariot
using Bases;

Console.WriteLine("foo");
Console.WriteLine("bar");

//Affichage sans retour chariot
Console.Write("foo2");
Console.WriteLine("bar2");

//retour chariot
Console.Write("foo3\r\n");
Console.Write("bar3\r\n");


Console.WriteLine("Entrez votre nom");
string name = Console.ReadLine();

Console.WriteLine(name + " est beau. Quand es-tu né(e)");

string repBirthYear = Console.ReadLine();

int birthYear = int.Parse(repBirthYear);

int age = DateTime.Now.Year - birthYear;

//age implicitement converti en string
Console.WriteLine("tu es né en " + birthYear + " tu as " + age + " ans");
//OU avec jeton
Console.WriteLine("tu es né en {0} tu as {1} ans", birthYear, age);
//OU interpollé
Console.WriteLine($"tu es né en {birthYear} tu as {age} ans");

//comm // ctrl k c
/*comm groupe de ligne ctrl shift /*/
//décomm ctrl k u

if (birthYear % 4 == 0)
{
    Console.WriteLine("tu es né une année bissextile");
}
else
{
    Console.WriteLine("tu n'es pas bissextile");
}

//en ternaire
string message = (birthYear % 4 == 0) ? "tu es né une année bissextile" : "tu n'es pas bissextile";
Console.WriteLine(message);

string slice;

const int minYear = 1900;
const int maxYear = 2022;

if (age > minYear || maxYear < 0)
{
    slice = "vous n'êtes pas né ou vous devriez être décédé";
}
else if (age > 35)
{
    slice = "vous avez plus de 35ans";
}
else if (age <= 35 && age > 15)
{
    slice = "vous avez entre 16 et 35ans";
}
else
{
    slice = "vous avez moins de 16ans";
}

Console.WriteLine(slice);

// pour éviter erreur arrondis : type décimal (pour des prix par exemple)

age += 5;

////////////////////////
string sentence = "Dom est si beau";
char letter = sentence[4];
Console.WriteLine(letter);

//créer un tableau array d'integers de 3 cases :
int[] array = new int[3];
array[0] = 55;
array[1] = 5;
array[2] = 557;
//OU
int[] array2 = { 55, 5, 557 };

Console.WriteLine(array2.Length);
Console.WriteLine(array2[0]);

for (int i = 0; i < sentence.Length; i++)
{
    Console.WriteLine($"position {i} : {sentence[i]}");
}

int j = 0;
while (j < sentence.Length)
{
    Console.WriteLine($"position {j} : {sentence[j]}");
    j++;
    //ou
    //Console.WriteLine($"position {j} : {sentence[j++]}");
}

//OU

j = 0;
do
{
    Console.WriteLine($"position {j} : {sentence[j++]}");
} while (j < sentence.Length);


int nbWord = TextAnalysis.countWord(sentence);

Console.WriteLine($"nombre de mot de la phrase : {nbWord}");


