
using WordAnalysis;

/*char toto = (char)120;
Console.WriteLine(toto);*/

Console.WriteLine("Donnes-moi un mot");

string word = Console.ReadLine();

Analyser.CountLetter(word, out int letters, out int vowels, out int consonants);

Console.WriteLine($"{word} comporte {letters} lettres, {vowels} voyelles et {consonants} consonnes.");