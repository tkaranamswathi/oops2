using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2UNIQUE
{
     class Unique
     {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };

            List<int> uniqueElements = GetUniqueElements(numbers);

            Console.WriteLine("Unique elements in the array:");

            foreach (int element in uniqueElements)
            {
                Console.WriteLine(element);
            }
        }

        static List<int> GetUniqueElements(int[] numbers)
        {
            List<int> uniqueElements = new List<int>();

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            foreach (var kvp in frequency)
            {
                if (kvp.Value == 1)
                {
                    uniqueElements.Add(kvp.Key);
                }
            }

            return uniqueElements;
        }
     }
}

