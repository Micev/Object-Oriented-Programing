using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs eventArgs);
    public class Student
    {
        private string name;
        private int age;
       
        private PropertyChangedEventArgs changedArgs;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter Student name...");
                }
                if (value != this.Name)
                {
                    this.changedArgs = new PropertyChangedEventArgs("Name", this.Name, value);
                    this.OnPropertyChanged(this, changedArgs);
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Please enter correct student age...");
                }
                if (value != this.Age)
                {
                    this.changedArgs = new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString());
                    this.OnPropertyChanged(this, changedArgs);
                }
                this.age = value;
            }
        }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs changedArgs)
        {
            if (PropertyChanged != null)
            {
                
                PropertyChanged(this, changedArgs);
            }
        }
        
    }
}
