using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Course_4th
{
    internal class Program
    {
        // read 
        // reverse 
        // print



        static string ReverseNumber(string stNum)
        {

            string ReversedNum = "";

            for (int i = stNum.Length - 1; i >= 0; i--)
            {
                ReversedNum += stNum[i];
            }


            return ReversedNum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(ReverseNumber(Console.ReadLine()));

        }
    }
}
//  
