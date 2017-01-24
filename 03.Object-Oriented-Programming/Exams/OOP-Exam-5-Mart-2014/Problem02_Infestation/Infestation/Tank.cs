using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Tank : Unit
    {
        public Tank(string name)
            : base(name, UnitClassification.Mechanical, 20, 25, 25)
        {

        }
    }
}
