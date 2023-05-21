using System;

namespace LAB2728
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Expression expression = new Expression();
            for (int i = 0;;)
            {
                string Temp = "";
                Console.WriteLine("\nВведіть доступну команду:\n(new - ініціалізувати нові параметри для виразу)\n(expression - переглянути вираз)\n(end - завершити виконання програми)");
                Temp = Console.ReadLine();

                if (Temp == "new")
                {
                    double a = 0, b = 0, c = 0, d = 0;
                    try
                    {
                        Console.WriteLine("\nВведіть значення параметрів: ");

                        Console.Write("\na = ");
                        a = double.Parse(Console.ReadLine());

                        Console.Write("\nb = ");
                        b = double.Parse(Console.ReadLine());

                        Console.Write("\nc = ");
                        c = double.Parse(Console.ReadLine());

                        Console.Write("\nd = ");
                        d = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nНекоректні дані!");
                        continue;
                    }

                    try
                    {
                        expression = new Expression(a, b, c, d);
                        Console.WriteLine($"\n lg(4 * b - c) * a\n------------------- = {Math.Round(expression.GetResult(),2)}\n    b + c/d - 1");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                else if (Temp == "expression")
                {
                    Console.WriteLine($"\n lg(4 * b - c) * a\n-------------------\n    b + c/d - 1");
                }
                else if (Temp == "clear")
                {
                    Console.Clear();
                }
                else if (Temp == "end")
                {
                    break;
                }
            }
        }
    }
}