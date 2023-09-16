namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                Console.WriteLine("Введите расстояние в сантиметрах, на которое прыгнул ученик:");
                int расстояние = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите ступень ученика (1, 2, 3 или 4):");
                int ступень = Convert.ToInt32(Console.ReadLine());

                switch (ступень)
                {
                    case 1:
                        if (расстояние >= 110)
                        {
                            Console.WriteLine("Ученик сдал норму ГТО по прыжкам на 1 ступени");
                        }
                        else
                        {
                            Console.WriteLine("Ученик не сдал норму ГТО по прыжкам на 1 ступени");
                        }
                        break;

                    case 2:
                        if (расстояние >= 125)
                        {
                            Console.WriteLine("Ученик сдал норму ГТО по прыжкам на 2 ступени");
                        }
                        else
                        {
                            Console.WriteLine("Ученик не сдал норму ГТО по прыжкам на 2 ступени");
                        }
                        break;

                    case 3:
                        if (расстояние >= 140)
                        {
                            Console.WriteLine("Ученик сдал норму ГТО по прыжкам на 3 ступени");
                        }
                        else
                        {
                            Console.WriteLine("Ученик не сдал норму ГТО по прыжкам на 3 ступени");
                        }
                        break;

                    case 4:
                        if (расстояние >= 150)
                        {
                            Console.WriteLine("Ученик сдал норму ГТО по прыжкам на 4 ступени");
                        }
                        else
                        {
                            Console.WriteLine("Ученик не сдал норму ГТО по прыжкам на 4 ступени");
                        }
                        break;

                    default:
                        Console.WriteLine("Некорректный номер ступени");
                        break;
                }
            }
        }

    }
}
