using System;
using System.Collections.Generic;

namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        List<Pilot> pilots = new List<Pilot>();
        List<Tank> tanks = new List<Tank>();
        List<Fighter> fighters = new List<Fighter>();

        public IPilot HirePilot(string name)
        {
            Pilot p = new Pilot(name);
            pilots.Add(p);
            return p;
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            Tank t = new Tank(name, attackPoints, defensePoints);
            tanks.Add(t);
            return t;
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            Fighter f = new Fighter(name, attackPoints, defensePoints, stealthMode);
            fighters.Add(f);
            return f;
        }
    }
}

