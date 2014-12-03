using System;
using Bank.Interfaces;

namespace Bank
{
    class AccountMortgage : Account, IDeposit, IAccount
    {
        public AccountMortgage(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int month)
        {
            if (this.Customer is CustomerCompany)
            {
                if (month <= 12)
                {
                    return base.CalculateInterest(month) / 2;
                }
                else
                {
                    return base.CalculateInterest(12) / 2 + base.CalculateInterest(month - 12);
                }
            }

            if (this.Customer is CustomerIndividuals)
            {
                if (month > 6)
                {
                    return base.CalculateInterest(month - 6);
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
