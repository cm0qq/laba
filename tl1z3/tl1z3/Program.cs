using System;

namespace tl1z3
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
                double asq = Math.Pow(a, 2);
                double bsq = Math.Pow(b, 2);
                double csq = Math.Pow(c, 2);
                if (a == 0 || a < 0 || b == 0 || b < 0 || c == 0 || c < 0 || a + b < c || a + c < b || b + c < a)
                {
                    Console.WriteLine("Такого треугольника не существует");
                }
                else
                {
                    if (csq < asq + bsq)
                    {
                        double p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                        Console.WriteLine("Треугольник остроугольный, его площадь: " + s);
                    }
                    if (csq > asq + bsq)
                    {
                        double p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                        Console.WriteLine("Треугольник тупоугольный, его площадь: " + s);
                    }
                    if (csq == asq + bsq)
                    {
                        double p = (a + b + c) / 2;
                        double s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                        Console.WriteLine("Треугольник прямоугольный, его площадь: " + s);
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
