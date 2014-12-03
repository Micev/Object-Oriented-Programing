using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Animal
    {
        public Tomcat(string name, int age, string gender = "male")
            :base(name,age,gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Mouuu...");
        }
    }
}
