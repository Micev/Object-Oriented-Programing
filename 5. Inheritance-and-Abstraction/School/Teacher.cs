using System;
using System.Collections.Generic;

namespace School
{
    public class Teacher : People,IDetails
    {
        private  List<Disciplines> discipline;
        private string details;


        public Teacher(string name, List<Disciplines> discipline, string details = null)
            : base(name)
        {
            this.Discipline = discipline;
            this.Details = details;
        }

        public List<Disciplines> Discipline {
            get { return this.discipline; }
            set
            { 
                this.discipline = value;
            }
        }
        public string Details { get; set; }
    }
}
