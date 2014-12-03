using System;
using System.Collections.Generic;
using Bank.Interfaces;
namespace Bank
{
    public abstract class Customers : ICustomer
    {
        private string name;

        public Customers(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.name = value;
            }
        }
    }
}
