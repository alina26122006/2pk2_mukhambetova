namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внимание, если вводите не целое число, то вводите его через запятую, а не точку");
            Console.WriteLine("Введите значения a"); //прошу пользователя ввести данные
            double a = double.Parse(Console.ReadLine()); //ввожу переменные
            Console.WriteLine("Введите значения b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значения c");
            double c = double.Parse(Console.ReadLine());
            double res1 = (3 * Math.Log(a) * 8) / (Math.Sin(b / 3 * a)); // ввожу первую часть задачи 
            double res2 = 3 * Math.Sqrt(5 * Math.Pow(a, 2) + 7); //вторая часть задачи
            double res3 = (4 * Math.Abs(c - (2 * a) + 1)) / Math.Sqrt(8 * a); //последняя часть задачи
            double result = res1 - res2 + res3; // объединение
            Console.WriteLine("Результат:" + result); //результат
        }
    }
}