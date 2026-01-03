using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{

    internal class Program
    {
        static Random rand = new Random();



        static int GenerateRandomNumber(int minvalue = 0, int maxvalue = 10)
        {


            return rand.Next(minvalue, maxvalue);

        }
        static int[,] FillMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            for (int R = 0; R < rows; R++)
            {
                for (int C = 0; C < columns; C++)
                {

                    matrix[R, C] = GenerateRandomNumber();
                }
            }

            return matrix;


        }

        static void PrintMatrix(int[,] Matrix, int rows, int columns)
        {
            for (int R = 0; R < rows; R++)
            {
                for (int C = 0; C < columns; C++)
                {

                    Console.Write($"{Matrix[R, C]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintMatrix(FillMatrix(10, 10), 10, 10);
        }
    }
}

