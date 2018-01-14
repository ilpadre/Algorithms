using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (long i = 10; i >= 0; i--)
            {
                var result = Fact.Factorial(i);
                Console.WriteLine("The factorial of {0} is {1}", i, result);
            }

            Console.ReadLine();

        }
    }
}
