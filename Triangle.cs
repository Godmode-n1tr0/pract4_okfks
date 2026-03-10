using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4_okfks
{
    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle (double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c<= 0)
            {
                throw new ArgumentException("Стороны должно быть положительными");
            }

            if (a + b <= c ||  a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }
            SideA = a;
            SideB = b;
            SideC = c;
        }
        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p-SideA) * (p - SideB) * (p-SideC));
        }

        public override string ToString()
        {
            return $"Треугольник: A={SideA}, B={SideB}, C={SideC}";
        }
    }

}
