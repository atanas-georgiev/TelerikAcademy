using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        public override double CalculateSurface()
        {
            return 2 * Math.PI * base.height;
        }

        public override string ToString()
        {
            return String.Format("Circle with radius {0}", base.height);
        }
    }
}
