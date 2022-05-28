using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            int min, max, n, sum;
            Console.WriteLine("Input the starting range of number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of number :");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect numbers within the given range :");
            for (int i = min; i <= max; i++)
            {
                n = 1;
                sum = 0;
                while (n < i)
                {
                    if (i % n == 0)
                        sum += n;
                    n++;
                }
                if (sum == n)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
