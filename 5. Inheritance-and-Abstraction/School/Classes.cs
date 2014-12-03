using System;
using System.Collections.Generic;


namespace School
{
    public class Classes : IDetails
    {
        private static List<string> uniqueID;
        private string className;
        private List<Teacher> teachers;
        private string details;

        static Classes()
        {
            Classes.uniqueID = new List<string>();
        }
        public Classes(string className, List<Teacher> teacher, string details = null)
        {
            this.ClassName = className;
            this.Teachers = teachers;
            this.Details = details;
            uniqueID.Add(className);
        }

        public string ClassName
        {
            get { return this.className; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Negative Class name!!!");
                }
                if (uniqueID.Contains(value))
                {
                    throw new ArgumentException("There is class with same name, chose different.");
                }
                this.className = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
               
                this.teachers = value;
            }
            
        }
        public string Details { get; set; }
    }
}
