using AreaCounter.Interfaces;
using System;

namespace AreaCounter.Figures
{
    public class Triangle : ITriangle
    {
        public double A { get ; init; }
        public double B { get; init; }
        public double C { get; init; }
        
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Длина сторон не может быть отрицательной");

            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Не треугольник");
            }
        }

        public bool IsRectangular()
        {
            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) ||
               Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) ||
               Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2))
            {
                return true;
            }

            return false;
        }

        public double GetSquare()
        {
            double HalfPerimeter = (A + B + C) / 2;

            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - A)
                                               * (HalfPerimeter - B)
                                               * (HalfPerimeter - C));
        }
    }
}
