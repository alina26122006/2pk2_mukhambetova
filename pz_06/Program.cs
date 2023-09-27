using System;

namespace pz_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];// Создаем массив из 10 элементов
            Random random = new Random();// Создаем псевдослучайный генератор чисел
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < array1.Length; i++)// Заполняем массив случайными числами в интервале [20,100]
            {
                array1[i] = random.Next(20, 101); Console.Write(array1[i] + " ");
            }
            int[] array2 = new int[10]; // Создаем второй массив для чисел, оканчивающихся на 0
            int count = 0;
            Console.WriteLine("\n\nЧисла, оканчивающиеся на 0:");
            for (int i = 0; i < array1.Length; i++)// Проверяем каждое число в первом массиве
            {            
                if (array1[i] % 10 == 0)// Если число оканчивается на 0, записываем его во второй массив
                {
                    array2[count] = array1[i]; count++;
                    Console.Write(array1[i] + " ");
                }
            }
            Console.WriteLine("\n\nМассив чисел, оканчивающихся на 0:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}