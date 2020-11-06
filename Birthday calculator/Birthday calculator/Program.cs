using System;

namespace Birthday_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Day, Month, Year;
            int d, m, y, age;
            {
                while (true)
                {
                    Console.Clear();
                    DateTime now = DateTime.Today;
                    Console.WriteLine("Здравствуйте.");
                    Console.WriteLine("Введите своё имя");
                    Name = Console.ReadLine();
                    {
                        try
                        {
                            Console.WriteLine("Введите день своего рождения");
                            Day = Console.ReadLine();
                            d = Convert.ToInt32(Day);
                            if (d > 31 | d < 1)
                            {
                                Console.WriteLine("Данные введены некорректно, попробуйте снова.");
                                Console.ReadLine();
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    try
                    {
                        Console.WriteLine("Введите номер месяца своего рождения");
                        Month = Console.ReadLine();
                        m = Convert.ToInt32(Month);
                        if (m > 12 | m < 1)
                        {
                            Console.WriteLine("Данные введены некорректно, попробуйте снова.");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    try
                    {
                        Console.WriteLine("Введите год своего рождения");
                        Year = Console.ReadLine();
                        y = Convert.ToInt32(Year);
                        if (y > now.Year | y < (now.Year - 120))
                        {
                            Console.WriteLine("Данные введены некорректно, попробуйте снова.");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    {
                        {
                            if (m == now.Month)
                                if (d > now.Day) { age = now.Year - y - 1; }
                                else { age = now.Year - y; }
                            else { age = now.Year - y; }
                            if (m > now.Month) { age = now.Year - y - 1; }
                        }
                        Console.WriteLine("Привет, " + Name + ".Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}