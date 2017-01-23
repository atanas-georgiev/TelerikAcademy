using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Pilot : IPilot
    {
        List<IMachine> machines;
        private string name;
        public Pilot(string n)
        {
            this.name = n;
            machines = new List<IMachine>();
        }
        public string Name
        {
            get { return this.name; }
        }

        public void AddMachine(IMachine machine)
        {
            //if (machine.Pilot != null)
            {
                machine.Pilot = this;
                machines.Add(machine);
            }
        }

        public string Report()
        {
            StringBuilder str = new StringBuilder();
            if (machines == null || machines.Count == 0)
            {
                str.Append(String.Format("{0} - no machines", this.name));
            }
            else if (machines.Count == 1)
            {
                str.Append(String.Format("{0} - 1 machine\n", this.name));
            }
            else
            {
                str.Append(String.Format("{0} - {1} machines\n", this.name, this.machines.Count));
            }

            if (machines != null)
            {
                int cnt = 0;
                foreach (Machine machine in machines)
                {
                    if (cnt != 0)
                    {
                        str.Append(String.Format("\n"));
                    }
                    str.Append(String.Format("- {0}\n", machine.Name));
                    if (machine is Tank)
                    {
                        str.Append(String.Format(" *Type: Tank\n"));
                    }
                    else if (machine is Fighter)
                    {
                        str.Append(String.Format(" *Type: Fighter\n"));
                    }

                    str.Append(String.Format(" *Health: {0}\n", machine.HealthPoints));
                    str.Append(String.Format(" *Attack: {0}\n", machine.AttackPoints));
                    str.Append(String.Format(" *Defense: {0}\n", machine.DefensePoints));

                    if (machine.Targets.Count == 0)
                    {
                        str.Append(String.Format(" *Targets: None\n"));
                    }
                    else
                    {
                        str.Append(String.Format(" *Targets: "));
                        for (int i = 0; i < machine.Targets.Count; i++)
                        {
                            str.Append(String.Format("{0}", machine.Targets[i]));
                            if (i != machine.Targets.Count - 1)
                                str.Append(String.Format(", "));
                        }
                        str.Append(String.Format("\n"));
                    }

                    if (machine is Tank)
                    {
                        str.Append(String.Format(" *Defense: {0}", (machine as Tank).DefenseMode == true ? "ON" : "OFF"));
                    }

                    if (machine is Fighter)
                    {
                        str.Append(String.Format(" *Stealth: {0}", (machine as Fighter).StealthMode == true ? "ON" : "OFF"));
                    }
                    cnt++;
                }
            }

            return str.ToString();
        }
    }
}
