using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Shop
{
    class Laptop
    {
        private string model;
        private double price;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;
        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;

        }

        public Laptop(string model, double price, string manufacturer = null, string processor = null, int ram = 0, string graphicCard = null
            , string hdd = null, string screen = null, Battery battery = null) 
            :this(model,price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;

        }
      

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid Modul value!!!");
                this.model = value;
            }
        }
        public double Price 
        {
            get { return this.price; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Invalid prive value!!!");
                this.price = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid manufacturer value!!!");
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid processor value!!!");
                this.processor = value;
            }
        }
        public int RAM
        {
            get { return this.ram; }
            set
            {
                if (value <1) throw new ArgumentException("Invalid ram value!!!");
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get { return this.graphicCard; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid graphic card value!!!");
                this.graphicCard = value;
            }
        }
        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid HDD value!!!");
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid HDD value!!!");
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public override string ToString()
        {
            string result = "Model: "+this.model+"\nPrice: "+this.price + "lv.";
            if (manufacturer != null) result += "\nManufacturer: "+this.manufacturer;
            if (processor != null) result += "\nProcessor: " + this.processor;
            if (ram !=0)  result += "\nRAM: " + this.ram + " GB"; 
            if (graphicCard != null) result += "\nGrapric card: " + this.graphicCard;
            if (hdd != null) result += "\nHDD: " + this.hdd;
            if (screen != null) result += "\nScreen: " + this.screen;
            if (battery != null) result +=   this.battery.ToString();
            return result.ToString();
        }
    }
}
