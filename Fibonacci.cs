﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public static void CheckFibonacci()
        {
            int fibo, fibo1 = 0, fibo2 = 1;
            Console.WriteLine("Enter the number to find Fibonacci series :");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < num; i++)
            {
                Console.Write(fibo1 + " ");

                fibo = fibo1;
                fibo1 = fibo2;
                fibo2 = fibo + fibo2;
            }
            Console.ReadKey();
        }
    }
}