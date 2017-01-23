using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Machine : IMachine
    {
        protected double attackPoints;
        protected double defensePoints;
        protected IList<string> targets;
        public Machine()
        {

        }
        public Machine(string name, double attPoints, double defPoints, double healthPoints)
        {
            this.Name = name;
            this.attackPoints = attPoints;
            this.defensePoints = defPoints;            
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name { get; set; }

        public IPilot Pilot { get; set; }

        public double HealthPoints { get; set; }

        public double AttackPoints
        {
            get { return attackPoints; }
        }

        public double DefensePoints
        {
            get { return defensePoints; }
        }

        public IList<string> Targets
        {
            get { return targets; }
        }

        public void Attack(string target)
        {
            targets.Add(target);
        }
    }
}
