using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7REVERSE
{
     class Reverse
    {
        static void Main(string[] args)
        {
            string input = "Hello World! How are you?";

            string reversedString = ReverseWords(input);

            Console.WriteLine("Reversed string: " + reversedString);
        }

        static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }
    }
}

