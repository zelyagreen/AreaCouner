using AreaCounter.Interfaces;
using System;

namespace AreaCounter.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; init; }

        public Circle(double radius)
        {
            if (radius == 0)
                throw new ArgumentException("Неверно указан радиус круга. Ошибка - вырожденная окружность", nameof(radius));

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
