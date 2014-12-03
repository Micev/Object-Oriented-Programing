using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Disciplines : IDetails
    {
        private string name;
        private int numOfLecture;
        List<Student> students;
        string details;

        public Disciplines(string name, int numOfLecture, List<Student> students, string details = null)
        {
            this.Name = name;
            this.NumOfLecture = numOfLecture;
            this.Students = students;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!!!");
                }
                this.name = value;
            }
        }

        public int NumOfLecture {
            get { return this.numOfLecture; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lection can't be negative!!!");
                }
                this.numOfLecture = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("student can't be null");
                }
                this.students = value;
            }
        }
        public string Details { get; set; }
    }
}
