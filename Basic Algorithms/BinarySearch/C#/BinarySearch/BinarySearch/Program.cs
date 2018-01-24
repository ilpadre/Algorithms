using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        /*
         *
         * This program implements the binary search algorithm as specified
         * in The Art of Computer Programming, Donald Knuth, 2nd Edition, pp. 409-411
         *
         * Algorithm Binary Search
         * Given a table of records R1, R2, ..., Rn whose keys are in increasing order
         * K1 < K2 < ... < Kn, this algorithm searches for a given argument K.
         *
         * 1. [Initialize] Set l = 1, u = n
         * 2. [Get Midpoint] (At this point we know that if K is in the table, it satisfies
         *      Kl <= K <= Ku.) If u < l, the algorithm terminates unsuccessfully. Otherwise
         *      set i = Floor((l+u)/2), the approximate midpoint of the relevant table area.
         * 3. [Compare] If K < Ki, go to Step 4; if K > Ki, go to Step 5; and if K = Ki, the
         *      algorithm terminates successfully.
         * 4. [Adjust u] Set u = i-1 and return to Step 2.
         * 5. [Adjust l] Set l = i+1 and return to Step 2.
         *
         */
        public static void Main(string[] args)
        {
            var numCompares = 0;
            var data = LoadArray();
            var item1 = 653;
            var item2 = 400;
            var item3 = 61;
            CheckResult(Search(item1, data, out numCompares), item1, numCompares);
            CheckResult(Search(item2, data, out numCompares), item2, numCompares);
            CheckResult(Search(item3, data, out numCompares), item3, numCompares);


            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
        }

        private static void CheckResult(int index, int item, int numCompares)
        {
            if (index >= 0)
            {
                Console.WriteLine($"Success! found {item} at index {index} in {numCompares} comparisons.");
            }
            else
            {
                Console.WriteLine($"Search failed! Could not find {item} in the array. It took {numCompares} comparisons.");
            }

            Console.WriteLine();

        }

        private static void PrintArray(int[] arr, int l, int u, int mid)
        {
            var val = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                val = arr[i].ToString();
                if (i == l)
                {
                    val = '[' + val;
                }
                if (i == u)
                {
                    val+= ']';
                }
                if (i == mid)
                {
                    val = '-' + val + '-';
                }
                Console.Write($" {val} ");
            }
            Console.WriteLine();
        }


        private static int[] LoadArray()
        {
            return new int[] { 61, 87, 154, 170, 275, 426, 503, 509, 512, 612, 653, 677, 703, 765, 897, 908 };
        }


        public static int Search(int x, int[] arr, out int numCompares)
        {
            numCompares = 0;
            var l = 0;
            var u = arr.Length - 1;
            while (u >= l)
            {
                var mid = ((l + u) / 2);
                PrintArray(arr, l, u, mid);
                numCompares++;
                if (x == arr[mid])
                {
                    return mid;
                }
                else if (x < arr[mid])
                {
                    u = --mid;
                }
                else if (x > arr[mid])
                {
                    l = ++mid;
                }
            }
            return -1;
        }
    }
}
