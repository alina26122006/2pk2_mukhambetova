namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:"); string input = Console.ReadLine();
            string output = ReplaceYears(input);
            Console.WriteLine("Изменённая строка:");
            Console.WriteLine(output);
        }
        static string ReplaceYears(string input)
        {
            string output = input;
            for (int year = 1999; year >= 1000; year--)// Все года от 1999 до 1000            {
                string yearString = year.ToString();// Изменяем год на строку
            output = output.Replace(yearString, "****");// Заменяем все года на "****"            }
            return output;
        }
    }
}