using System;

namespace тл1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите стороны треугольника: ");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                if (a == 0 || a < 0 || b == 0 || b < 0 || c == 0 || c < 0 || a + b < c || a + c < b || b + c < a)
                {
                    Console.WriteLine("Такого треугольника не существует");
                }
                else
                {
                    if (a != b && b != c && c != a)
                    {
                        double p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                        Console.WriteLine("Треугольник разносторонний, его площадь: " + s);
                    }
                    if (a == b && a != c || a == c && a != b || b == c && b != a)
                    {
                        double p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                        Console.WriteLine("Треугольник равнобедренный, его площадь: " + s);
                    }
                    if (a == b && a == c)
                    {
                        double p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                        Console.WriteLine("Треугольник равносторонний, его площадь: " + s);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Неправильно введены данные!");
            }
        }
    }
}
