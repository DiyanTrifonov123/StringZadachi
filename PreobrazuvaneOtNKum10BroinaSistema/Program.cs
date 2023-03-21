using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreobrazuvaneOtNKum10BroinaSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи основа и число в съответната основа: ");
            string[] input = Console.ReadLine().Split();
            int osnova = int.Parse(input[0]);
            string num = input[1];

            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int cifra = num[i] - '0';
                result = result * osnova + cifra;
            }
            Console.WriteLine($"Числото {num} в 10-ична бройна система: {result}");
        }
    }
}
