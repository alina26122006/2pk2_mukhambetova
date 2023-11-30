namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            int h; //вввели переменную 
            for (h = 10; h <= 100; h += 5) //сам цикл
            {
                Console.WriteLine(h);

            }

            //Задание 2
            Console.WriteLine("Задание 2");
            int n;
            char startChar = 'A';
            for (n = 0; n < 5; n++)
            {
                Console.Write((char)(startChar + n) + " ");
            }
            Console.WriteLine();
            //Задание 3
            Console.WriteLine("Задание 3");
            int f = 6;
            int m = 7;
            for (int p = 0; p < f; p++)
            {
                for (int jp = 0; jp < m; jp++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            //задание 4
            Console.WriteLine("Задание 4");
            int b = 0;
            int x = 1000;
            int d = 6;
            int o = 0;
            for (int ip = b; ip <= x; ip++)
            {
                if (ip % d == 0)
                {
                    Console.Write(ip + " ");
                    o++;
                }
            }
            Console.WriteLine("\nКоличество кратных чисел: " + o);
            // Задание 5
            Console.WriteLine("Задание 5");
            int i = 3;
            int j = 50;

            for (int aa = i, oo = j; j - aa >= 27; aa++, oo--)
            {
                Console.WriteLine("i: " + aa + ", j: " + oo);
            }
        }
    }
}