

namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;
    class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(int numberOfLegsF, string modelF, MaterialType materialF, decimal priceF, decimal heightF)
            : base(modelF, materialF, priceF, heightF)
        {
            this.numberOfLegs = numberOfLegsF;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
        }
    }
}
