using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{

    internal class Program
    {// inverted Pattern 
     //  read input 
     // Print Pattern -->  
     //
     //                

        static int ReadPostiveNumber(string PrintingMessage)
        {
            int Num;

            Console.WriteLine(PrintingMessage);
            do
            {
                Num = int.Parse(Console.ReadLine());
                if (Num <= 0)
                    Console.WriteLine("Enter Positive Number");
                else
                    return Num;

            } while (true);


        }


        static void PrintPattern(int Number)
        {
            for (int i = Number; i > 0; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();

            }
        }

        static void Main(string[] args)
        {
            PrintPattern(ReadPostiveNumber("Enter Number to print Inverted Pattern"));
        }
    }
}
