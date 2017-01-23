

namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;
    class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;

        public ConvertibleChair(int numberOfLegsF, string modelF, MaterialType materialF, decimal priceF, decimal heightF)
            : base(numberOfLegsF, modelF, materialF, priceF, heightF)
        {
            isConverted = false;
        }
        public bool IsConverted
        {
            get { return isConverted; }
        }

        public void Convert()
        {
            if (isConverted)
            {
                isConverted = false;
            }
            else
            {
                isConverted = true;
            }
        }

        public override decimal Height
        {
            get
            {
                if (isConverted)
                {
                    return 0.10m;
                }
                else
                {
                    return base.height;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
