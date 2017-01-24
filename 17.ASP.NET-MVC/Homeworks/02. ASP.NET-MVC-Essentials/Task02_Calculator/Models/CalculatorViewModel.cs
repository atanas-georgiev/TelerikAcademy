using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02_Calculator.Models
{
    public class CalculatorViewModel
    {
        public IList<DataType> DataTypes;
        public IList<int> Multipliers;

        public double Input { get; set; }
        public string SelecteDataType { get; set; }
        public int SelectedMultiplier { get; set; }

        public void UpdateData()
        {
            this.DataTypes = new List<DataType>()
            {
                new DataType() {Name = "Bit", Coefficient = 1},
                new DataType() {Name = "Byte", Coefficient = 8},
                new DataType() {Name = "Kilobit", Coefficient = this.SelectedMultiplier},
                new DataType() {Name = "Kilobyte", Coefficient = 8*this.SelectedMultiplier},
                new DataType() {Name = "Megabit", Coefficient = Math.Pow(this.SelectedMultiplier, 2)},
                new DataType() {Name = "Megabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 2)},
                new DataType() {Name = "Gigabit", Coefficient = Math.Pow(this.SelectedMultiplier, 3)},
                new DataType() {Name = "Gigabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 3)},
                new DataType() {Name = "Terabit", Coefficient = Math.Pow(this.SelectedMultiplier, 4)},
                new DataType() {Name = "Terabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 4)},
                new DataType() {Name = "Petabit", Coefficient = Math.Pow(this.SelectedMultiplier, 5)},
                new DataType() {Name = "Petabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 5)},
                new DataType() {Name = "Exabit", Coefficient = Math.Pow(this.SelectedMultiplier, 6)},
                new DataType() {Name = "Exabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 6)},
                new DataType() {Name = "Zettabit", Coefficient = Math.Pow(this.SelectedMultiplier, 7)},
                new DataType() {Name = "Zettabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 7)},
                new DataType() {Name = "Yottabit", Coefficient = Math.Pow(this.SelectedMultiplier, 8)},
                new DataType() {Name = "Yottabyte", Coefficient = 8*Math.Pow(this.SelectedMultiplier, 8)}
            };
        }

        public CalculatorViewModel()
        {
            this.Multipliers = new List<int>()
            {
                1000,
                1024
            };

            UpdateData();

            this.SelectedMultiplier = this.Multipliers[0];           
            this.SelecteDataType = (string)this.DataTypes[0].Name.Clone();
        }


        public double GetSelectedCoefficient()
        {
            return this.Input * DataTypes.FirstOrDefault(d => d.Name == SelecteDataType).Coefficient;
        }
    }
}