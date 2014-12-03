using System;
using Bank.Interfaces;

namespace Bank
{
    public abstract class Account : IAccount, IDeposit
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        
        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid customer!");
                }
                this.customer = value;
            }
           
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int month)
        {
            return this.Balance * (1 + this.InterestRate * (decimal)month / 100);
        }
        public virtual void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }
    }
}
