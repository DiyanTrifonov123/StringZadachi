using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObryshtaneNaNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи символен низ: ");
            string input = Console.ReadLine();
            string output = ReverseString(input);
            Console.WriteLine($"Въведения символен низ наобратно: {output}");
        }

        private static string ReverseString(string input)
        {
            char[] simvoli = input.ToCharArray();
            int lqvo = 0;
            int dqsno = simvoli.Length - 1;

            while (lqvo < dqsno)
            {
                char x = simvoli[lqvo];
                simvoli[lqvo] = simvoli[dqsno];
                simvoli[dqsno] = x;

                lqvo++;
                dqsno--;
            }
            return new string (simvoli);
        }
    }
}
