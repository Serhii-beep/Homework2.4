using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side) : base(side, side, side)
        {
        }

        protected override double CalculateArea()
        {
            return Math.Sqrt(3) * Side1 * Side1 / 4;
        }
    }
}
