using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // FizzBuzz
    //  Write a program that prints the numbers from 1 to 100. 
    //  But for multiples of three print “Fizz” instead of the number 
    //  and for the multiples of five print “Buzz”. For numbers which 
    //  are multiples of both three and five print “FizzBuzz”.
    public class Program
    {
        private const int Max = 100;
        public static void Main(string[] args)
        {
            BruteForce();
            BetterWay();
            Console.ReadLine();
        }

        private static void BruteForce()
        {
            Console.WriteLine("Brute force is my middle name:");
            Console.WriteLine();
            for (int i = 1; i <= Max; i++)
            {
                Console.WriteLine(FilterdVal(i));
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static string FilterdVal(int i)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                    return "FizzBuzz";
                else
                    return "Fizz";
            }
            else if (i % 5 == 0)
                return "Buzz";
            else
                return i.ToString();
        }

        private static void BetterWay()
        {
            Console.WriteLine("There's got to be a better way:");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
