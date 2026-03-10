using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4_okfks
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Ширина и высота должны быть положительными");
            }
                Width = width;
                Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public override string ToString()
        {
            return $"Прямоугольник: Width={Width}, Height={Height}";
        }
    }
}
