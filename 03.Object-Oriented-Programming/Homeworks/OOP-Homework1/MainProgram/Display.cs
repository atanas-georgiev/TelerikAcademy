using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProgram
{
    class Display
    {
        // Constant Fields
        private const double MaxSize = 100;
        private const double MinSize = 1;

        // Fields
        private double size;
        private long colors;

        // Constructors
        public Display() { }
        public Display(double size = 1, long colors = 1)
        {
            this.Size = size;
            this.Colors = colors;
        }

        // Properties
        public double Size
        {
            get { return size; }
            set
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentException("Invalid size!");
                }
                size = value;
            }
        }

        public long Colors
        {
            get { return colors; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Invalid colors value");
                colors = value;
            }
        }

    }
}
