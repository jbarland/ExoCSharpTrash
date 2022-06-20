using TestMinMax;

/*DateTime[] myDates = { DateTime.Today, new DateTime(2021, 6, 5), new DateTime(2020,1,1)  };
GenericNb.GetMinMax(myDates, out DateTime min, out DateTime max);

Console.WriteLine("min :" + min);
Console.WriteLine("max :" + max);

int[] myInts = { 84, 5, 16, 1, 102, 99 };
GenericNb.GetMinMax(myInts, out int min1, out int max1);

Console.WriteLine("min :" + min1);
Console.WriteLine("max :" + max1);
*/

int[] myInts = { 84, 5, 16, 1, 102, 99 };

(int min, int max) = GenericNb.GetMinMax(myInts);
Console.WriteLine("min :" + min);
Console.WriteLine("max :" + max);

string[] myLetters = { "k", "a", "z", "f" };
(string, string) miniMaxi = GenericNb.GetMinMax(myLetters);
Console.WriteLine(miniMaxi);    



GenericNb.TriBulle(myInts);

for (int i = 0; i < myInts.Length; i++)
{
    Console.WriteLine(myInts[i]);

}
