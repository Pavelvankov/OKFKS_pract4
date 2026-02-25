using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Некорректные стороны треугольника");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double GetSideC()
        {
            return sideC;
        }

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override string ToString()
        {
            return $"Треугольник: Стороны = {sideA}, {sideB}, {sideC}";
        }
    }
}
