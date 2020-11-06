using System;

namespace NumberSystems
{
    class Program
    {
        static long CalculateToBinary(long dec, int systemOutput)
        {
            string number = null;
            int i = 0;
            while (dec >= systemOutput)
            {
                long x = dec / systemOutput;
                long numeral = dec - systemOutput * x;
                number = numeral.ToString() + number;
                dec = dec / systemOutput;
                i = i + 1;
                Console.WriteLine($"Шаг {i}: {number}");
                Console.WriteLine($"Остаток от деления: {dec}");
            }
            number = dec.ToString() + number;
            return long.Parse(number);
        }
        static bool CheckCorrectness(int systemInput, long a)
        {
            string lineNumber = a.ToString();
            for (int i = 0; i < lineNumber.Length; i++)
            {
                if (int.Parse(lineNumber[i].ToString()) >= systemInput) return false;
            }
            return true;
        }
        static long CalculateToDecimal(long a, int systemInput)
        {
            string x = a.ToString();
            long z = 0;
            for (int i = 0; i < x.Length; i++)
            {
                long number = (a / (long)Math.Pow(10, x.Length - i - 1)) % 10;
                long grade = (long)Math.Pow(systemInput, x.Length - i - 1);
                z = z + number * grade;
                Console.WriteLine($"Шаг {i + 1}: {z}");
            }
            return z;
        }
        enum Alphabet
        {
            A, a = 10,

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine(10);
                    Console.Write("Введите систему счисления числа до 10-ой: ");
                    int systemInput = int.Parse(Console.ReadLine());
                    Console.Write("Введите число: ");
                    long a = long.Parse(Console.ReadLine());

                    if (!CheckCorrectness(systemInput, a))
                    {
                        Console.WriteLine("Ошибка!");
                        break;
                    }
                    Console.Write("Введите в какую систему счисления вы бы хотели его перевести до 10-ой: ");
                    int systemOutput = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    long b=0;
                    if (systemOutput == 2 || systemOutput < 10 )
                    {
                        long dec = CalculateToDecimal(a, systemInput);
                        Console.WriteLine($"Число в десятичной системе счисления: {dec}");
                        Console.WriteLine("");
                        b = CalculateToBinary(dec, systemOutput);
                    }
                    if ( systemOutput == 10 ) 
                    { 
                        b = CalculateToDecimal(a, systemInput); 
                    }
                    Console.WriteLine($"Число в заданой системе счисления: {b}");
                    Console.WriteLine(Alphabet.a);
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}