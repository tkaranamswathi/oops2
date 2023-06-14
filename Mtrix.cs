using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC9MATRIX
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[] rowSums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                }
                rowSums[i] = sum;
            }

            Console.WriteLine("Sum of each row:");

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Row " + (i + 1) + ": " + rowSums[i]);
            }
        }
    }
}

