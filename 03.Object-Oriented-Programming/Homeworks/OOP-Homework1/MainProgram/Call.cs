using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MainProgram
{
    class Call
    {
        // Fields
        private DateTime dateTime;
        private string number;
        private int duration;

        // Constructors
        public Call() { }
        public Call(DateTime dt, string number, int duration)
        {
            this.DateTimeValue = dt;
            this.Number = number;
            this.Duration = duration;
        }

        // Properties
        public DateTime DateTimeValue
        {
            get { return dateTime; }
            set 
            {
                try
                {
                    dateTime = DateTime.Parse(value.ToString());
                }
                catch
                {
                    throw new ArgumentException ("Not valid date/time entered!");
                }                
            }
        }

        public string Number
        {
            get { return number; }
            set 
            {
                if (CheckNumber(value))
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException ("Not valid number entered!");
                }                
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value > 0)
                {
                    duration = value;
                }
                else
                {
                    throw new ArgumentException("Not valid duration entered!");
                }
            }
        }

        private static bool CheckNumber(string strPhoneNumber)
        {
           string MatchPhoneNumberPattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
           if (strPhoneNumber!= null) return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern );
           else return false;
        }
    }
}
