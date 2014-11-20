using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Shop
{
    class Battery
    {
        private string type;
        private double hours;

        public Battery(string type)
        {
            this.Type = type;
        }

        public Battery(string type, double hours)
            : this(type)
        {
            this.Hours = hours;

        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid battery value!!!");
                this.type = value;
            }
        }

        public double Hours
        {
            get { return this.hours; }
            set
            {
                if (value < 0) throw new ArgumentException("Wrong hour!!!");
                this.hours = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (this.type != null)
            {
                result+="\nbattery: " + this.type;
            }
            if (this.Hours > 0)
            {
                result += "\nbattery life: " + this.hours;
            }
            return result.ToString();
        }
    }
}
