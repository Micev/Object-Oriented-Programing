using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Timer
{
    class TestTimer
    {
        public static void Work1(string str)
        {
            Console.Write(str);
        }

        public static void Work2(string str)
        {
            Random r = new Random();
                //Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);
                Console.Beep();
            
        }
        public static void Main()
        {
            AsyncTimer timer1 = new AsyncTimer(Work1, 1000, 20);
            timer1.Start();

            AsyncTimer timer2 = new AsyncTimer(Work2, 800,20);
            
            timer2.Start();
        }
    }
}
