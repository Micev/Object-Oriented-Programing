using System;
using Bank.Interfaces;

namespace Bank
{
    class CustomerIndividuals : Customers,ICustomer
    {
        public CustomerIndividuals(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}
