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
    public class Zombie : Animal
    {
        public Zombie(string name, Point location)
            : base(name, location, 0)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return 10;
        }
    }
}
