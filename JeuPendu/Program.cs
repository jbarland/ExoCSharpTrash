using JeuPendu;

Console.WriteLine("Jouez au pendu!");


string word = string.Empty;
bool wordOk = false;

while (!wordOk)
{
    try
    {
        Console.WriteLine("Saisissez un mot de 3 à 25 lettres sans accent");
        word = Console.ReadLine();
        HangmanGame.CheckWord(word);
        wordOk = true;
        Console.WriteLine(word);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.Clear();

HangmanGame game = new HangmanGame(word);
bool ok = false;

while (!ok)
{
    Console.WriteLine("lettre :");
    char tryLetter = char.Parse(Console.ReadLine());
    game.WordState(tryLetter);
    Console.WriteLine(game.StateWord);

    if (game.GameStates == GameStates.Win || game.GameStates == GameStates.Lose)
    {
        ok = true;
    }
}

if (game.GameStates == GameStates.Win)
{
    Console.WriteLine("Bravo");
}
if (game.GameStates == GameStates.Lose)
{
    Console.WriteLine("Perdu");
}