using System;

namespace Ex1_Console
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public string Exists {
            get
            {
                return (a < b + c && b < a + c && c < a + b) ? "Да" : "Нет";
            }
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ShowSides()
        {
            Console.WriteLine($"Длина стороны A: {a}");
            Console.WriteLine($"Длина стороны B: {b}");
            Console.WriteLine($"Длина стороны C: {c}");
        }

        public double GetPerimeter()
            => a + b + c;

        public double GetSquare()
        {
            double p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
