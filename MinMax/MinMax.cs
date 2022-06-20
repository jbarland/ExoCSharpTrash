using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMinMax
{
    public class GenericNb
    {
        /*public static void GetMinMax<T>(T[] numbers, out T min, out T max) where T : IComparable<T>
        {
            min = numbers[0];
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                        
                if (numbers[i].CompareTo(min) == -1)
                {
                    min = numbers[i];
                }
                else if (numbers[i].CompareTo(max) == 1)
                {
                    max = numbers[i];
                }             

            }

        }*/

        //TUPLES
        public static (T, T) GetMinMax<T>(T[] numbers) where T : IComparable<T>
        {
            T min = numbers[0];
            T max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i].CompareTo(min) == -1)
                {
                    min = numbers[i];
                }
                else if (numbers[i].CompareTo(max) == 1)
                {
                    max = numbers[i];
                }

            }

            return (min, max);

        }

        public static int[] TriBulle(int[] myTab)
        {
            int c;
            for (int j = 0; j < myTab.Length; j++)
            {
                for (int i = 0; i < myTab.Length - 1 - j; i++)
                {
                    if (myTab[i] > myTab[i + 1])
                    {
                        c = myTab[i];
                        myTab[i] = myTab[i+1];
                        myTab[i + 1] = c;
                    }

                }

            }
            return myTab;
        }
    }
}
