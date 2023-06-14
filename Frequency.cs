using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3FREQUENCY
{
    class Frequency
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };

            Dictionary<int, int> frequency = CountElementFrequency(numbers);

            Console.WriteLine("Element Frequency:");

            foreach (var kvp in frequency)
            {
                Console.WriteLine("Element: " + kvp.Key + ", Frequency: " + kvp.Value);
            }
        }

        static Dictionary<int, int> CountElementFrequency(int[] numbers)
        {
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

            return frequency;
        }
    }
}

