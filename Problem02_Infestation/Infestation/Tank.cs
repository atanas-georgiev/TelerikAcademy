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

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id)
            {
                attackUnit = true;
            }
            return attackUnit;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            return attackableUnits.LastOrDefault();
        }
    }
}
