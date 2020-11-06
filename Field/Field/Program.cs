using System;

namespace Field
{
    class Program
    {
        static void DrawDownCells(int widthField, int widthCell, int indentLeft)
        {
            Console.Write('└');
            for (int i = 0; i < widthCell + 1; i++)
            {
                Console.Write("─");
            }
            for (int i = 0; i < widthField - 1; i++)
            {
                Console.Write('┴');
                for (int j = 0; j < widthCell + 1; j++)
                {
                    Console.Write("─");
                }
            }
            Console.WriteLine('┘');
            return;
        }
        static void DrawDivideCells(int widthField, int widthCell, int indentLeft)
        {
            Console.Write('├');
            for (int i = 0; i < widthCell + 1; i++)
            {
                Console.Write("─");
            }
            for (int i = 0; i < widthField - 1; i++)
            {
                Console.Write('┼');
                for (int j = 0; j < widthCell + 1; j++)
                {
                    Console.Write("─");
                }
            }
            Console.WriteLine('┤');
            return;
        }
        static void DrawCentralCells(int widthField, int widthCell, int indentLeft)
        {
            Console.Write('│');
            for (int i = 0; i < widthCell + 1; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < widthField - 1; i++)
            {
                Console.Write('│');
                for (int j = 0; j < widthCell + 1; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine('│');
            return;
        }

        static void DrawUpCells(int widthField, int widthCell, int indentLeft)
        {
            Console.Write('┌');
            for (int i = 0; i < widthCell + 1; i++)
            {
                Console.Write("─");
            }
            for (int i = 0; i < widthField - 1; i++)
            {
                Console.Write('┬');
                for (int j = 0; j < widthCell + 1; j++)
                {
                    Console.Write("─");
                }
            }
            Console.WriteLine('┐');
            return;
        }
        static void Main(string[] args)
        {
            int widthField = 3;
            int heightField = 4;
            int widthCell = 3;
            int heightCell = 2;
            int indentLeft = 3;
            int indentUp = 0;
            DrawUpCells(widthField, widthCell, indentLeft);
            for (int i = 0; i < heightCell; i++)
            {
                DrawCentralCells(widthField, widthCell, indentLeft);
                DrawDivideCells(widthField, widthCell, indentLeft);
            }
            DrawCentralCells(widthField, widthCell, indentLeft);
            DrawDownCells(widthField, widthCell, indentLeft);
        }
    }
}
