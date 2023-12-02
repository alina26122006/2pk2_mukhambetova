using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            // Создаем файл с именем S.txt
            using (StreamWriter sw = new StreamWriter(input + ".txt"))
            {
                Console.WriteLine("Введите текст для записи в файл, для завершения введите пустую строку:");
                string line;

                // Записываем текст построчно
                while (!string.IsNullOrEmpty(line = Console.ReadLine()))
                {
                    sw.WriteLine(line);
                }

                // Определяем длину самой большой строки
                int maxLength = GetMaxLength(input + ".txt");

                // Дописываем символ «*» до длины самой большой строки
                sw.BaseStream.Seek(0, SeekOrigin.End);
                foreach (string str in File.ReadLines(input + ".txt"))
                {
                    sw.WriteLine(str.PadRight(maxLength, '*'));
                }
            }

            Console.WriteLine($"Файл {input}.txt успешно создан и заполнен.");
        }

        // Функция для нахождения длины самой большой строки
        static int GetMaxLength(string filename)
        {
            int maxLength = 0;
            foreach (string line in File.ReadLines(filename))
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }
    }
}
