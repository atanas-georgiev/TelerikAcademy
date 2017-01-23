

namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;

    class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(int numberOfLegsF, string modelF, MaterialType materialF, decimal priceF, decimal heightF)
            : base(numberOfLegsF, modelF, materialF, priceF, heightF)
        {

        }

        public void SetHeight(decimal height)
        {
            base.height = height;
        }
    }
}
