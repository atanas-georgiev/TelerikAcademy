using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Fighter : Machine, IFighter
    {
        private bool stealthMode;
         public Fighter(string name, double attackPoints, double defensePoints, bool sMode)
            : base(name, attackPoints, defensePoints, 200)
        {
            this.stealthMode = sMode;            
        }
        public bool StealthMode
        {
            get { return stealthMode; }
        }

        public void ToggleStealthMode()
        {
            if (stealthMode == true)
            {
                stealthMode = false;
            }
            else
            {
                stealthMode = true;
            }
        }
    }
}
