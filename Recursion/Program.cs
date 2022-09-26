using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial time!");
            int n = 0;
            while(!int.TryParse(Console.ReadLine(), out n));
            Factorial(n);
        }


        /// <summary>
        /// Factorial
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        private static string Factorial(int number)
        {
            int count = number - 1;

            number = number * count;

            if (count != 1)
            {
                Factorial(number);
            }
            else
            {
                return (int number);

            }
        }
    }
}
