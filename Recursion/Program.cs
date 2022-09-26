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
            Console.WriteLine(Factorial(n));
            
        }

        /// <summary>
        /// Factorial
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        private static int Factorial(int number)
        {
            if (number == 1)
            {
                return (number);
            }
            return number * Factorial(number - 1);
        }
    }
}