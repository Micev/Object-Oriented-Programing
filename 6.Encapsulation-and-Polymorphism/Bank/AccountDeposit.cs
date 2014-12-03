using System;
using Bank.Interfaces;

namespace Bank
{
    class AccountDeposit : Account, IAccount, IDeposit
    {
        public AccountDeposit(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Withdrow(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int month)
        {
            if (this.Balance < 1000 && this.Balance>0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(month);
            }
        }

    }
}
