using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Text;

class PcCatalog
{
    static void Main(string [] arr)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
        Component motherboard = new Component("Intel gx754", 234);
        Component processor = new Component("Intel Dual Core 2.5GHz", 400);
        Component graphicsCard = new Component("Nvidia", 254);
        Component RAM = new Component("8 GB", 123);
        Component HDD = new Component("500GB 7200rpm", 125);
        Computer myPC = new Computer("Lenovo X70", new List<Component>() { motherboard, processor, graphicsCard, RAM, HDD });
        myPC.PrintInfo();
    }
}