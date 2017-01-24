using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProgram
{
    class GSM
    {
        // Constant Fields
        private const int MaxLength = 30;

        // Fields
        private static string iPhone4s = "Apple Iphone 4s telephone";
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> calls = new List<Call>();

        // Constructors
        public GSM() { }

        public GSM(string model, string manufacturer, double price = 0, string owner = "",
            double displaySize = 1, long displayColors = 1,
            string batteryModel = "NoName", double batteryIdleTime = 1, double batteryHoursTime = 1, Battery.BatteryType batteryType = Battery.BatteryType.LiIon)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.owner = owner;
            display = new Display(displaySize, displayColors);
            battery = new Battery(batteryModel, batteryIdleTime, batteryHoursTime, batteryType);
        }

        // Properties
        public static string IPhone4s
        {
            get { return iPhone4s; }
            set
            {
                if (value.Length > MaxLength)
                {
                    throw new ArgumentException("Invalid length!");
                }
                iPhone4s = value;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > MaxLength)
                {
                    throw new ArgumentException("Invalid length!");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length > MaxLength)
                {
                    throw new ArgumentException("Invalid length!");
                }
                manufacturer = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                price = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value.Length > MaxLength)
                {
                    throw new ArgumentException("Invalid length!");
                }
                owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return calls; }
            set { calls = value; }
        }

        // Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("------------------------------\n");
            result.Append("Main\n");
            result.Append("------------------------------\n");
            result.Append("Model: " + this.model + "\n");
            result.Append("Manufacturer: " + this.manufacturer + "\n");
            result.Append("Price: " + this.price + "\n");
            result.Append("Owner: " + this.owner + "\n");
            result.Append("------------------------------\n");
            result.Append("Display\n");
            result.Append("------------------------------\n");
            result.Append("Size: " + this.display.Size + "\n");
            result.Append("Colors: " + this.display.Colors + "\n");
            result.Append("------------------------------\n");
            result.Append("Battery\n");
            result.Append("------------------------------\n");
            result.Append("Model: " + this.battery.Model + "\n");
            result.Append("Type: " + this.battery.Type + "\n");
            result.Append("Idle Time: " + this.battery.IdleTime + "\n");
            result.Append("Talk Time: " + this.battery.HoursTime + "\n");
            result.Append("------------------------------\n");

            return result.ToString();
        }

        public void AddCall(DateTime dt, string number, int duration)
        {
            CallHistory.Add(new Call(dt, number, duration));
        }

        public void RemoveCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void ClearCalls()
        {
            CallHistory.Clear();
        }

        public double CalculateTotalCallsPrice(double pricePerMinute)
        {
            int totalSeconds = 0;

            foreach (var call in CallHistory)
            {
                totalSeconds += call.Duration;
            }

            return (totalSeconds / 60) * pricePerMinute;
        }
    }
}
