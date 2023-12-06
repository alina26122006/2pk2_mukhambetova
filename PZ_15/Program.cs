using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к каталогу:");
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    Console.WriteLine($"Вы хотите удалить файл {Path.GetFileName(file)}? Y или N");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        File.Delete(file);
                        Console.WriteLine($"Файл {Path.GetFileName(file)} удален");
                    }
                    else
                    {
                        Console.WriteLine($"Файл {Path.GetFileName(file)} оставлен без изменений");
                    }
                }
            }
            else
            {
                Console.WriteLine("Указанный каталог не существует");
            }
        }
    }
}
