namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;
            str = str.Trim(); //обрезка лишних пробелов с начала и конца строки

            for (int i = 0; i < str.Length; i++)
            {
                int j = 0;
                if (Char.IsWhiteSpace(str[i])) //если текущий символ является пробелом
                {
                    while (Char.IsWhiteSpace(str[i + j])) //пока все последующие символы являются пробелом
                    {
                        j++;
                    }
                    if (j == 1) count++; // увеличение счетчика
                }
            }
            Console.WriteLine(count + 1);
        }
    }
}