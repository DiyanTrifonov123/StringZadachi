using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreobrazuvaneOt10KumNBroinaSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи основа и число в 10-ична бройна система: ");
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int osnova = input[0];
            int num = input[1];
            int numAnswer = input[1];
            string result = "";

            while (num > 0)
            {
                int desetichno = num % osnova;
                result = desetichno.ToString()+ result;
                num = num / osnova;
            }

            Console.WriteLine($"Числото {numAnswer} в {osnova}-ична бройна система: {result}");
        }
    }
}
