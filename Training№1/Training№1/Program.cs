using System;
using System.IO;

namespace Training_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparingStrings(CountingMaxLines());
        }

        class Info
        {
            public static string[] firstFile = File.ReadAllLines("file1.txt");

            public static string[] secondFile = File.ReadAllLines("file2.txt");
        }

        static int CountingMaxLines ()
        {
            if (Info.firstFile.Length < Info.secondFile.Length) { return Info.secondFile.Length; }
            else { return Info.firstFile.Length; }
        }

        static void ComparingStrings(int maxLines)
        {
            int numberOfMinStr = 0;
            if (Info.firstFile.Length < maxLines) { numberOfMinStr = (Info.firstFile.Length - 1); }
            else if (Info.secondFile.Length < maxLines) { numberOfMinStr = (Info.secondFile.Length - 1); }
            for (int i = 0; i < maxLines; i++)
            {
                if (numberOfMinStr < i)
                {
                    if (numberOfMinStr < Info.firstFile.Length)
                    {
                        WriteChange(i, Info.firstFile[i], "");
                    }
                    else
                    {
                        WriteChange(i, "", Info.secondFile[i]);
                    }
                    continue;
                }

                if (Info.firstFile[i].Length == Info.secondFile[i].Length)
                {
                    string firstArg = Info.firstFile[i];
                    string secondArg = Info.secondFile[i];
                    for (int j = 0; j < Info.firstFile[i].Length; j++)
                    {
                        if (firstArg[j] != secondArg[j])
                        {
                            WriteChange(i, Info.firstFile[i], Info.secondFile[i]);
                            break;
                        }
                    }
                }
                else  { WriteChange(i, Info.firstFile[i], Info.secondFile[i]); }
            }
            return;
        }

        static void WriteChange(int numberStr, string firstStr, string secondStr)
        {
            Console.WriteLine($"{numberStr + 1}: {firstStr}");
            if (firstStr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{numberStr + 1}: +{secondStr}");
                Console.ResetColor();
                return;
            }
            else if (secondStr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{numberStr + 1}: -{secondStr}");
                Console.ResetColor();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{numberStr + 1}: ~{secondStr}");
            Console.ResetColor();
        }
    }
}