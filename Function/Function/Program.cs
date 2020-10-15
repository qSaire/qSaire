using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Парабола");
                    Console.Write("Введите x:");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите шаг для x:");
                    double step = double.Parse(Console.ReadLine());
                    Console.Write("Введите количество шагов:");
                    int count = int.Parse(Console.ReadLine());

                    double y = Math.Round(Function(x), 3);
                    Console.WriteLine("|--------|--------|");
                    Console.WriteLine("|   X    |    Y   |");
                    Console.WriteLine("|--------|--------|");
                    Console.WriteLine("|{0,8}|{1,8}|", x, y);
                    for (int i = 0; i < count; i++)
                    {
                        x = Math.Round(x + step, 3);
                        y = Math.Round(Function(x), 3);
                        Console.WriteLine("|{0,8}|{1,8}|", x, y);
                    }
                    Console.WriteLine("|--------|--------|");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода.");
                }
                Console.ReadLine();
            }
        }
        public static double Function(double x)
        {
            double y = x * x;
            return y;
        }
    }
}