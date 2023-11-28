using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, }; // Пример входных данных
            Array.Sort(a); // Сортировка массива по возрастанию
            double median = Median(a); // Вызов метода для нахождения медианы
            Console.WriteLine("Медиана: " + median); // Вывод результата на экран
        }

        // Метод для нахождения медианы в отсортированном массиве
        static double Median(int[] array)
        {
            int n = array.Length;
            if (n % 2 == 0) // Если количество элементов четное
            {
                // Возвращаем среднее арифметическое двух центральных элементов
                return (array[n / 2 - 1] + array[n / 2]) / 2.0;
            }
            else // Если количество элементов нечетное
            {
                // Возвращаем значение по формуле 
                return array[(n + 1) / 2 - 1];
            }
        }
    }
}

