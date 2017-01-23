//-----------------------------------------------------------------------
// <copyright file="Wolf.cs" company="n/a">
//     Copyright (c) avg, n/a. All rights reserved.
// </copyright>
// <summary>Wolf implementation</summary>
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
    public class Wolf : Animal, ICarnivore
    {
        public Wolf(string name, Point location)
            : base(name, location, 4)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null &&
                (animal.State == AnimalState.Sleeping ||
                animal.Size <= this.Size))
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }        
    }
}
