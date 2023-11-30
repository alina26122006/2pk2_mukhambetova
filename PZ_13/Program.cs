using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_13
{
    internal class Program
    {
        static double ArithmeticalProgression(int n)
        {
            if (n == 1)
            {
                return 0.5;
            }
            else
            {
                return ArithmeticalProgression(n - 1) + 0.3;
            }
        }

        static double GeometricalProgression(int n)
        {
            if (n == 1)
            {
                return 14;
            }
            else
            {
                return GeometricalProgression(n - 1) * 2;
            }
        }

        static void PrintNumbers(int A, int B)
        {
            if (A < B)
            {
                if (A <= B)
                {
                    Console.WriteLine(A);
                    PrintNumbers(A + 1, B);
                }
            }
            else
            {
                if (A >= B)
                {
                    Console.WriteLine(A);
                    PrintNumbers(A - 1, B);
                }
            }
        }

        static void Main()
        {
            int n;
            double result;

            // Задание 1
            n = 5; // Примерное значение n
            result = ArithmeticalProgression(n);
            Console.WriteLine($"n-й член арифметической прогрессии: {result}");

            // Задание 2
            n = 4; // Примерное значение n
            result = GeometricalProgression(n);
            Console.WriteLine($"n-й член геометрической прогрессии: {result}");

            // Задание 3
            int A = 5; // Примерные значения A и B
            int B = 10;
            PrintNumbers(A, B);
        }
    }
}


    
 

