using System;
using System.Collections.Generic;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!!!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name must be more of 2 charackters,");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Negative age.");
                }
                this.age = value;
            }
        }
        public string Genger
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Negative gender, chose male or female.");
                }
                this.gender = value;
            }
        }
    }
}
