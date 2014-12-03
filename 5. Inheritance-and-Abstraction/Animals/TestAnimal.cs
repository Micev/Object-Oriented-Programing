using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestAnimal
    {
        public static void Main()
        {
            Dog parcho = new Dog("Parcho", 8, "male");
            Dog kira = new Dog("Kira", 3, "female");

            Cat maxy = new Cat("Maxy", 5, "male");
            Cat sara = new Cat("Sara", 7, "female");

            Frog frogy = new Frog("Frogy", 4, "male");

            Kitten kitty = new Kitten("Kitty", 3);
            Tomcat tommy = new Tomcat("Tommy", 6);

            parcho.ProduceSound();
            maxy.ProduceSound();
            frogy.ProduceSound();
            kitty.ProduceSound();
            tommy.ProduceSound();

            List<Animal> animals = new List<Animal>()
            {
                parcho,
                kira,
                maxy,
                sara,
                frogy,
                kitty,
                tommy
            };

            var averageAge =
               from animal in animals
               group animal by animal.GetType() into g
               select new { GroupName = g.Key.Name, AverageAge = g.Average(a => a.Age) };

            averageAge.ToList().ForEach(a => Console.WriteLine(a.GroupName + " ----> " + a.AverageAge));
        }
    }
}
