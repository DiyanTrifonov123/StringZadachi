using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи символен низ: ");
            string input = Console.ReadLine();
            bool output = IsPalindrome(input);
            if (output== true)
            {
                Console.WriteLine($"Въведения символен низ {input} е палиндром {output}");
            }
            else
            {
                Console.WriteLine($"Въведения символен низ {input} НЕ е палиндром {output}");
            }
        }

        private static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
