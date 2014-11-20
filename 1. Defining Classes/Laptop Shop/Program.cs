using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery lenovoBattery = new Battery("Li-Ion, 4-cells, 2550 mAh",3.52);
            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", 1243.23, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",8,"Intel HD Graphics 4400", "128GB SSD", "13.3",lenovoBattery);
            Console.WriteLine(lenovo.ToString());
        }
    }
}
