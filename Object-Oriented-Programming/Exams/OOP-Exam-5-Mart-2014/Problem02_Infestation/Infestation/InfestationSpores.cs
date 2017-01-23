using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class InfestationSpores : Supplement
    {
        public InfestationSpores()
            : base(-1, 0, 20)
        {

        }

        public override void ReactTo1(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                var a = (Supplement)otherSupplement;
                a.aggressionEffect = 0;
                a.powerEffect = 0;
            }
        }
    }
}
