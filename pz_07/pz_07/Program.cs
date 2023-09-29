
namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив размером 6x7
            double[,] array = new double[6, 7];
            // Заполняем массив дробными числами с 1 знаком после запятой
            Random random = new Random(); for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 10, 1);
                }
            }

            // Выводим массив на экран
            Console.WriteLine("Массив:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Вычисляем произведение элементов 4-го столбца
            double product = 1.0; for (int i = 0; i < 6; i++)
            {            // 4-й столбец - индекс 3
                product *= array[i, 3];
            }
            // Выводим произведение на экран
            Console.WriteLine("Произведение элементов 4-го столбца: " + product);
            Console.ReadLine();
        }
    }
}