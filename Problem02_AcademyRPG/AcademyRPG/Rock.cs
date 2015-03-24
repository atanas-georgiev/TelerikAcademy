using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        protected int quantity { get; private set; }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
        }

        public Rock(Point position, int hitPoints)
            : base(position)
        {
            this.quantity = hitPoints / 2;
            this.HitPoints = hitPoints;            
        }
    }
}

