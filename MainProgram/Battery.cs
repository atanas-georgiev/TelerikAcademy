using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProgram
{
    class Battery
    {
        // Constant Fields
        private const int MaxLengthModel = 20;

        // Fields
        private string model;
        private double idleTime;
        private double hoursTime;
        private BatteryType type;

        // Constructors
        public Battery() { }

        public Battery(string model = "NoName", double idleTime = 1, double hoursTime = 1, BatteryType type = BatteryType.LiIon)
        {
            this.Model = model;
            this.idleTime = idleTime;
            this.hoursTime = hoursTime;
            this.Type = type;
        }

        // Enums
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }

        // Properties
        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Model
        {
            get { return model; }
            set 
            {
                if (value.Length > MaxLengthModel)
                    throw new ArgumentException("Name is too long!");
                model = value; 
            }
        }

        public double IdleTime
        {
            get { return idleTime; }
            set
            {
                if (value < 1 || value > 1000)
                    throw new ArgumentException("Invalid value!");
                idleTime = value;
            }
        }

        public double HoursTime
        {
            get { return hoursTime; }
            set
            {
                if (value < 1 || value > 1000)
                    throw new ArgumentException("Invalid value!");
                hoursTime = value;
            }
        }
    }
}
