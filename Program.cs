namespace UC6PATTERN2
{
    internal class Program
    {
   
            static void Main(string[] args)
            {
                int rows = 7;
                int cols = 7;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= cols; j++)
                    {
                        if (i == 1 || i == rows || j == 1 || j == cols)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        
    }
    
}