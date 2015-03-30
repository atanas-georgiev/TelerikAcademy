//-----------------------------------------------------------------------
// <copyright file="Wolf.cs" company="n/a">
//     Copyright (c) avg, n/a. All rights reserved.
// </copyright>
// <summary>Boar implementation</summary>
//-----------------------------------------------------------------------

namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Wolf implementation.
    /// </summary>
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        public Boar(string name, Point location)
            : base(name, location, 4)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.Size <= this.Size)
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(2);
            }

            return 0;
        }
    }
}
