using System;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                try
                {
                    double x, a, b;
                    Console.Write("Введите a:");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите b:");
                    b = double.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        x = (12 - b * a) / 2;
                        Console.WriteLine("x=" + x);
                    }
                    else
                    {
                        Console.WriteLine("Нет решения");
                    }
                }
                catch
                {
                    Console.WriteLine("Введите число, а не букву");
                }
            }
            
        }
    }
}
