using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    abstract class Shape
    {
        protected double height;
        protected double width;

        public Shape() { }

        public Shape(double h, double w)
        {
            this.width = w;
            this.height = h;
        }
        public abstract double CalculateSurface();
    }
}
