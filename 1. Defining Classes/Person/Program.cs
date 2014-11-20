using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email = null)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name!!!");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100) throw new ArgumentException("Invalid age!!!");
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if(value!=null && (value.Length<1 || !value.Contains("@")))
                    throw new ArgumentException("Invalid email!!!");
                this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: " + this.name + "\nAge: " + this.age +(this.Email==null?"":"\nEmail: "+this.email)+"\n");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 22);
            Person gosho = new Person("Gosho", 27, "Asfsdf@");

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
