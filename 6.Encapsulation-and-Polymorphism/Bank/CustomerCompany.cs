using System;
using System.Collections.Generic;
using Bank.Interfaces;

namespace Bank
{
    class CustomerCompany : Customers, ICustomer
    {
        public CustomerCompany(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}
