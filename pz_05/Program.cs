namespace pz_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            double v = 0;
            int i = 1;
            while (i <= n)
            {
                v += 1.0 / i;
                i++;
            }
            Console.WriteLine("Ответ:" + v);
            Console.ReadKey();
        }
    }
}