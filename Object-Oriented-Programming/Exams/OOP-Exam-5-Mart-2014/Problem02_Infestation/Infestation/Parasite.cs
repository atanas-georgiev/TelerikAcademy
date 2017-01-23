using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Parasite : Unit
    {
        public Parasite(string name)
            : base(name, UnitClassification.Biological, 1, 1, 1)
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

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

        public override void AddSupplement(ISupplement newSupplement)
        {
            base.AddSupplement(newSupplement);
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var res = attackableUnits.OrderBy(x => x.Health).FirstOrDefault<UnitInfo>();
            return res;
        }

    }
}
