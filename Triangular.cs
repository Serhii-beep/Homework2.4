using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry
{
    public class Triangle
    {
        public double Side1 { get; private set; } = 0.0;
        public double Side2 { get; private set; } = 0.0;
        public double Side3 { get; private set; } = 0.0;
        public double Angle1 { get; private set; } = 0.0;
        public double Angle2 { get; private set; } = 0.0;
        public double Angle3 { get; private set; } = 0.0;
        public double Perimeter { get; private set; } = 0.0;
        public double Area { get; private set; } = 0.0;

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            Angle1 = Math.Acos((Side2 * Side2 + Side3 * Side3 - Side1 * Side1) / (2 * Side2 * Side3));
            Angle2 = Math.Acos((Side1 * Side1 + Side3 * Side3 - Side2 * Side2) / (2 * Side1 * Side3));
            Angle3 = Math.PI - (Angle1 + Angle2);

            Perimeter = Side1 + Side2 + Side3;

            Area = CalculateArea();
        }

        protected virtual double CalculateArea()
        {
            double p = Perimeter / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
