using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Animal, ISound
    {
        public Kitten(string name, int age, string gender = "female")
            :base(name,age,gender)
        {
           
        }

        public void ProduceSound()
        {
            Console.WriteLine("Miaaauuu...");
        }
    }
}
