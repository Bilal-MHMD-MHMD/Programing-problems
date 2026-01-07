using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{

    internal class Program
    {
        public enum enMethod { Recursion, loop };
        static int FibonacciuNumberusingLoop(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            int perv1 = 1, perv2 = 1;

            int value = 0;

            for (int i = 2; i < n; i++)
            {
                value = perv1 + perv2;
                perv2 = perv1;                  // this order is important
                perv1 = value;


            }

            return value;

        }

        static int FibonacciNumberUsingRecursion(int n)
        {
            if (n <= 2)
                return 1;
            else
                return FibonacciNumberUsingRecursion(n - 1) + FibonacciNumberUsingRecursion(n - 2);
        }


        static void PrintingFibonacci(int n, enMethod Method)
        {
            switch (Method)
            {
                case enMethod.Recursion:

                    for (int i = 1; i <= n; i++)
                        Console.Write("{0} ", FibonacciNumberUsingRecursion(i));
                    break;

                case enMethod.loop:
                    for (int i = 1; i <= n; i++)
                        Console.Write("{0} ", FibonacciuNumberusingLoop(i));
                    break;

            }

        }

        static void Main(string[] args)
        {
            int SequenceLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci using Recursion");
            PrintingFibonacci(SequenceLimit, enMethod.Recursion);
            Console.WriteLine("\nFibonacci using Loop");
            PrintingFibonacci(SequenceLimit, enMethod.loop);
        }
    }
}
