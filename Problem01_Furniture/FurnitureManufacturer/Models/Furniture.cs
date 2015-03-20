
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;

    class Furniture : IFurniture
    {
        private string model;
        private MaterialType material;
        private decimal price;
        protected decimal height;

        public Furniture(string modelF, MaterialType materialF, decimal priceF, decimal heightF)
        {
            this.model = modelF;
            this.material = materialF;
            this.price = priceF;
            this.height = heightF;
        }

        public string Model
        {
            get { return this.model; }
        }

        public string Material
        {
            get { return this.material.ToString(); }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public virtual decimal Height
        {
            get { return height; }
        }
    }
}
