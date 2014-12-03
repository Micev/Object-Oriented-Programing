using System;
using Bank.Interfaces;

namespace Bank
{
    class AccountLoan : Account, IAccount, IDeposit
    {
        public AccountLoan(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int month)
        {
            if (this.Customer is CustomerCompany)
            {
                if (month > 2)
                {
                    return base.CalculateInterest(month - 2);
                }
                else
                {
                    return this.Balance;
                }
            }

            if (this.Customer is CustomerIndividuals)
            {
                if (month > 3)
                {
                    return base.CalculateInterest(month - 3);
                }
                else
                {
                    return this.Balance;
                }
            }
            return base.CalculateInterest(month);
        }
    }
}
