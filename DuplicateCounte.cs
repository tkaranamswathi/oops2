using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1DUPLICATEARRAY
{
    public class DuplicateCounter
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 5, 7, 5, 6, 3, 3, 4, 4, 1, 5 };
            Dictionary<int, int> countDict = new Dictionary<int, int>();

            // Count the occurrence of each element in the array
            foreach (int num in array)
            {
                if (countDict.ContainsKey(num))
                {
                    countDict[num]++;
                }
                else
                {
                    countDict[num] = 1;
                }
            }

            int duplicateCount = 0;

            // Count the number of elements with count greater than 1
            foreach (int count in countDict.Values)
            {
                if (count > 1)
                {
                    duplicateCount++;
                }
            }

            Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
        }
    }
}
