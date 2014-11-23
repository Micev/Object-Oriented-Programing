using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class StudentTest
    {
        public static void Main()
        {
            Student gosho = new Student("Gosho", 25);
            Student pesho = new Student("Pesho", 18);

            gosho.PropertyChanged+=(sender,eventArgs) =>
                Console.WriteLine("Property changed: {0} (from {1} to {2} )",eventArgs.Property,eventArgs.OldName,eventArgs.NewName);

            pesho.PropertyChanged+=(sender, eventArgs) =>
                 Console.WriteLine("Property changed: {0} (from {1} to {2} )", eventArgs.Property, eventArgs.OldName, eventArgs.NewName);

            gosho.Name = ("Georgi");
            gosho.Age = 27;
            pesho.Name = ("Petar");
            pesho.Age = 21;
        }
    }
}
