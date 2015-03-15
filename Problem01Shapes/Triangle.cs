using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return base.height * base.width / 2;
        }

        public override string ToString()
        {
            return String.Format("Triangle with width {0} and height {1}", base.height, base.width);
        }
    }
}
