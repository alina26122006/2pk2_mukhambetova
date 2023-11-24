using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 0;
            double result = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Введите число для вычисления третьей степени: ");
                a = double.Parse(Console.ReadLine());
                PowerA3(a, out result);
                Console.WriteLine($"{a} в третьей степени равно {result}");
            }
        }

        static void PowerA3(double a, out double result)
        {
            result = Math.Pow(a, 3);
        }
    }
}

        
    

