using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string maxString = string.Empty; // Переменная для хранения строки с максимальным количеством символов

            Console.WriteLine("Введите строки. Для завершения введите 'stop':");

            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "stop") // Проверяем, введено ли слово "stop"
                    break;

                if (input.Length > maxString.Length) // Если текущая строка длиннее предыдущей максимальной строки, обновляем maxString
                    maxString = input;
            }

            Console.WriteLine("Строка максимальной длины: " + maxString);
        }
    }
}
