using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student : People, IDetails
    {
        private string name;
        private static List<int> uniqueID;
        private int number;
        private string details;

        static Student()
        {
            Student.uniqueID = new List<int>();
        }
        public Student(string name, int number, string details = null)
            : base(name)
        {
            this.Number = number;
            this.Details = details;
            uniqueID.Add(number);
        }

        public int Number
        {
            get { return this.number; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Number of student can't be negative.");
                }
                if (uniqueID.Contains(value))
                {
                    throw new ArgumentException("Number of student exist, chose different.");
                }
            }
        }
        public string Details { get; set; }
    }
}
