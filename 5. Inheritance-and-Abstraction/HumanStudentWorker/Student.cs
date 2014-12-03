using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Student : Human
    {
        private string faultyNumber;

        public Student(string firstName, string lastName, string faultyNumber)
            : base(firstName, lastName)
        {
            this.FaultyNumber = faultyNumber;
        }
        public string FaultyNumber
        {
            get { return this.faultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("invalid number");
                }
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("number must be from 5 to 10 charackters.");
                }
                this.faultyNumber = value;
            }
        }
        public override string ToString()
        {
           return base.ToString() + string.Format("\nFaculty number: {0}", this.FaultyNumber);
        }
    }
}
