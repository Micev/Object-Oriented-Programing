using System;


namespace School
{
    public class People 
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
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
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must hava minimum 3 charackter!!!");
                }
                this.name = value;
            }
        }
       
    
    }
}
