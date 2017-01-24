using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return base.height * base.width;
        }

        public override string ToString()
        {
            return String.Format("Rectangle with width {0} and height {1}", base.height, base.width);
        }
    }
}
