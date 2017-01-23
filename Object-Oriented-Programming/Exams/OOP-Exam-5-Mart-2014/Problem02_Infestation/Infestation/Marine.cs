using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Marine : Human
    {
        public Marine(string name)
            : base(name)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id)
            {
                if (this.Aggression >= unit.Power)
                {
                    attackUnit = true;
                }
            }
            return attackUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            return base.DecideInteraction(units);
        }

        public override void AddSupplement(ISupplement newSupplement)
        {
            base.AddSupplement(newSupplement);
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var res = attackableUnits.OrderBy(x => x.Health).LastOrDefault<UnitInfo>();
            return res;
        }

    }
}
