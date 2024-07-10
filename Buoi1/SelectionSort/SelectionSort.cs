using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class SelectionSort
    {
        static void Main()
        {
            Console.Title = "Selection Sort";
            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int m = i;
                int maxValue = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j].CompareTo(maxValue) > 0)
                    {
                        m = j;
                        maxValue = numbers[j];
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[m];
                numbers[m] = temp;


            }
            Console.ReadKey();
        }
    }
}
