using System;

namespace Factorial
{
    class Program
    {
        static long GetMaxLength(long z)
        {
            string num = z.ToString();
            long maxLength = num.Length;
            return maxLength;
        }
        static void DrawFrame(long maxLength, char firstWall, char roof, char secondWall)
        {
            Console.Write(firstWall);
            for (int i = 0; i < maxLength; i++)
                Console.Write(roof);
            Console.WriteLine(secondWall);
        }
        static void DrawFrame(long maxLength, char firstWall, char roof, char secondWall, long y)
        {
            Console.Write(firstWall);
            Console.Write(roof);
            Console.Write(y);
            string filledSpace = y.ToString();
            long space = maxLength - filledSpace.Length - 1;
            for (int i = 0; i < space; i++)
                Console.Write(roof);

            Console.WriteLine(secondWall);
        }
        static long CalculateFactorial(long x)
        {
            long y = 1;
            for (int i = 1; i <= x; i++)
            {
                y = y * i;
            }
            return y;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write("Введите число, для которого хотите получить факториал:");
                    int x = int.Parse(Console.ReadLine());
                    int strNum = x;
                    long factorial = CalculateFactorial(x);
                    long maxLength = GetMaxLength(factorial) + 2;

                    DrawFrame(maxLength, '╔', '═', '╗');
                    DrawFrame(maxLength, '║', ' ', '║');
                    DrawFrame(maxLength, '║', ' ', '║', CalculateFactorial(x));
                    DrawFrame(maxLength, '║', ' ', '║');
                    DrawFrame(maxLength, '╚', '═', '╝');
                }
                catch (Exception)
                {
                    Console.Write("Что-то пошло не так.");
                }
                Console.ReadLine();
            }
        }
    }
}
