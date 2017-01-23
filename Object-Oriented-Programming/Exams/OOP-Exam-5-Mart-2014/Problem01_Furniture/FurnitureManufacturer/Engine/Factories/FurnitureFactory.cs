namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            if (CheckPreconditions(model, price, height))
            {
                return new Table(length, width, model, this.GetMaterialType(materialType), price, height);
            }

            return null;
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (CheckPreconditions(model, price, height))
            {
                return new Chair(numberOfLegs, model, this.GetMaterialType(materialType), price, height);
            }

            return null;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (CheckPreconditions(model, price, height))
            {
                return new AdjustableChair(numberOfLegs, model, this.GetMaterialType(materialType), price, height);
            }

            return null;
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (CheckPreconditions(model, price, height))
            {
                return new ConvertibleChair(numberOfLegs, model, this.GetMaterialType(materialType), price, height);
            }

            return null;
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }

        private bool CheckPreconditions(string model, decimal price, decimal height)
        {
            if ((model != "") &&
               (model != null) &&
               (model.Length >= 3) &&
               (price > 0) &&
               (height > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
