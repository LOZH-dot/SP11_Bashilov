using System;

namespace Ex1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            while (true)
            {
                try
                {
                    Console.Write("Введите сторону треугольника (a): ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Введите сторону треугольника (b): ");
                    b = int.Parse(Console.ReadLine());

                    Console.Write("Введите сторону треугольника (c): ");
                    c = int.Parse(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("ожидается ввод целого числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine("\n");

            Triangle triangle = new Triangle(a, b, c);

            triangle.ShowSides();


            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.GetSquare()}");
            Console.WriteLine($@"Существует ли треугольник: {triangle.Exists}");

            while (true)
            {
                try
                {
                    Console.Write("Введите новое значение стороны треугольника (a): ");
                    triangle.A = int.Parse(Console.ReadLine());

                    Console.Write("Введите новое значение стороны треугольника (b): ");
                    triangle.B = int.Parse(Console.ReadLine());

                    Console.Write("Введите новое значение стороны треугольника (c): ");
                    triangle.C = int.Parse(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка");
                    Console.ResetColor();
                    Console.WriteLine("ожидается ввод целого числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("\n");

            triangle.ShowSides();


            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.GetSquare()}");
            Console.WriteLine($@"Существует ли треугольник: {triangle.Exists}");
        }
    }
}
