namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число c, которое является целым");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите число d, которая является действительным");
            double d = Double.Parse(Console.ReadLine());
            double s, t, v; //добавила переменные
            if (c < 0) //условие
            {
                s = c - (d * Math.Pow(c, 3)) / d;
            }
            else 
            { 
                s = c * d -16;
            }
            if (s > 4.5)
            {
                t = Math.Pow(Math.Cos(c - d / s - d), 2);
            }
            else
            {
                t = Math.Cos(2 * c) + 2 * c;
            }
            v = (c + 3 * d - 1.1 * s * t) / 1.8;
            Console.WriteLine("Результат" + v);



            }
    }
}