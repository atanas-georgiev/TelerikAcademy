using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : Machine, ITank
    {
        private bool defenceMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, 100)
        {
            this.defenceMode = false;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get { return defenceMode; }
        }

        public void ToggleDefenseMode()
        {
            if (defenceMode == true)
            {
                base.defensePoints -= 30;
                base.attackPoints += 40;
                defenceMode = false;
            }
            else
            {
                base.defensePoints += 30;
                base.attackPoints -= 40;
                defenceMode = true;
            }
        }
    }
}
