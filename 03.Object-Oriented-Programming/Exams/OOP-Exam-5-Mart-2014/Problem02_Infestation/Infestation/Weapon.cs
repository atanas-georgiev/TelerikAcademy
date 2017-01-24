using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Weapon : Supplement
    {
        public Weapon()
            : base(0, 0, 0)
        {
            
        }

        public override void ReactTo1(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                base.powerEffect += 10;
                base.aggressionEffect += 3;
            }
            
        }
    }
}
