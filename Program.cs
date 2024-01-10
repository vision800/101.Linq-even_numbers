using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101.Linq_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //linq is used for data structures manipulation

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };

            var result = from num in numbers
                         where num%2 == 0
                         select num;

            foreach(var nm in result)
            {
                Console.WriteLine(nm);
            }
        }
    }
}
