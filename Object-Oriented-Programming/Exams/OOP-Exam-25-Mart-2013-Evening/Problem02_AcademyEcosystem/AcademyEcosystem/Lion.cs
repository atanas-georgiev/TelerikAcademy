//-----------------------------------------------------------------------
// <copyright file="Wolf.cs" company="n/a">
//     Copyright (c) avg, n/a. All rights reserved.
// </copyright>
// <summary>Lion implementation</summary>
//-----------------------------------------------------------------------

namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Lion implementation.
    /// </summary>
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, Point location)
            : base(name, location, 6)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.Size <= 2 * this.Size)
            {
                this.Size++;
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}