using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4MAXANDMIN
{
    class Maxandmin
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 7, 4 };

            int maximum = FindMaximum(numbers);
            int minimum = FindMinimum(numbers);

            Console.WriteLine("Maximum element: " + maximum);
            Console.WriteLine("Minimum element: " + minimum);
        }

        static int FindMaximum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }

            int maximum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
            }

            return maximum;
        }

        static int FindMinimum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }

            int minimum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            return minimum;
        }
    }
}

