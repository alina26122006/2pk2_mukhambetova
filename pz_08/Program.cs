namespace pz_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Начальный массив");
                double[][] arr = new double[10][];// Создаем ступенчатый масси
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    int length = random.Next(10, 30);// Генерируем длину второго измерения
                    arr[i] = new double[length];
                    for (int j = 0; j < arr[i].Length; j++)// Заполняем массив случайными значениями
                    {
                        arr[i][j] = random.NextDouble();
                    }
                }
                for (int i = 0; i < arr.Length; i++)  // Выводим массив
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                 Console.WriteLine("Последний элементы каждой строки:");
                double[] result = new double[arr.Length]; // Создаем новый одномерный массив    
                for (int i = 0; i < arr.Length; i++)// Записываем последние элементы каждой строки
                {
                    result[i] = arr[i][arr[i].Length - 1];
                }
                for (int i = 0; i < result.Length; i++) // Выводим новый массив
                {
                    Console.Write(result[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Максимальный элемент");
                double[] maxElements = new double[arr.Length]; // Создаем массив для максимальных элементов
                for (int i = 0; i < arr.Length; i++) // Находим максимальный элемент в каждой строке
                {
                    double max = double.MinValue;
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] > max)
                        {
                            max = arr[i][j];
                        }
                    }
                    maxElements[i] = max;
                }
                for (int i = 0; i < maxElements.Length; i++) // Выводим массив максимальных элементов
                {
                    Console.Write(maxElements[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Обновленный массив");
                for (int i = 0; i < arr.Length; i++) // Меняем местами первый элемент и максимальный в каждой строке
                {
                    double temp = arr[i][0];
                    arr[i][0] = maxElements[i];
                    maxElements[i] = temp;
                }
                for (int i = 0; i < arr.Length; i++)// Выводим обновленный массив
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Обновленный массив после реверса");
                }
                for (int i = 0; i < arr.Length; i++)// Реверс каждой строки массива
                {
                    Array.Reverse(arr[i]);
                }

                for (int i = 0; i < arr.Length; i++)// Выводим обновленный массив после реверса
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < arr.Length; i++) // Подсчитываем среднее значение в каждой строке
                {
                    double sum = 0;
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        sum += arr[i][j];
                    }
                    double average = sum / arr[i].Length;
                    Console.WriteLine("Среднее значение в строке " + i + ": " + average);
                }
            }
        }

    }

