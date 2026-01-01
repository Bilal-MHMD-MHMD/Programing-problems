using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Course_4th
{
    internal class Program
    {





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

        static int ReadDigit(string PrintingMessage)
        {
            int Digit;

            do
            {
                Digit = ReadPostiveNumber(PrintingMessage);

                if (Digit > 9)
                    Console.WriteLine("Valid range from 0 to 9");

                else
                    return Digit;

            } while (true);
        }

        static int CalculateFrequency(int Num, int Digit)
        {
            int Frequency = 0;
            string stNum = Num.ToString();

            for (int i = 0; i < stNum.Length; i++)
            {
                if (int.Parse(stNum[i].ToString()) == Digit)
                    Frequency++;
            }
            return Frequency;

        }
        static void Main(string[] args)
        {

            int Number = ReadPostiveNumber("Enter Number");

            int Digit = ReadDigit("Enter Digit to Search");

            Console.WriteLine($"Frequency of digit : {Digit} in Number : {Number} is {CalculateFrequency(Number, Digit)}");

        }
    }
}
