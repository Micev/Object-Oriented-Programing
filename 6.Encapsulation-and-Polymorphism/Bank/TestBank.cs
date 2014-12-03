using System;
using System.Collections.Generic;
using Bank.Interfaces;

namespace Bank
{
    class TestBank
    {
        public static void Main()
        {
            ICustomer gosho = new CustomerIndividuals("gosho");
            ICustomer IBM = new CustomerCompany("IBM");

            IAccount individualDepositAccount = new AccountDeposit(gosho, 2142, 24m);
            IAccount companyDepositAccount = new AccountDeposit(IBM, 56234m, 12m);
            IAccount individualLoanAccount = new AccountLoan(gosho, 789m, 9m);
            IAccount companyloanAccount = new AccountLoan(IBM, 10543m, 18m);
            IAccount individualMortgageAccount = new AccountMortgage(gosho, 2000m, 10m);
            IAccount companyMortgageAccount = new AccountMortgage(IBM, 7850m, 6m);

            List<IAccount> accounts = new List<IAccount>()
            {
                individualDepositAccount,
                companyDepositAccount,
                individualLoanAccount,
                companyloanAccount,
                individualMortgageAccount,
                companyMortgageAccount
            };
            int mount = 12;
            foreach (var account in accounts)
            {
                Console.WriteLine("{0} have {1} with balance {2:N2}\n  and new balanse for {3} mount is {4:N2} ",
                    account.Customer.Name, account.GetType().Name, account.Balance, mount, account.CalculateInterest(mount));
                Console.WriteLine();
            }

        }
    }
}
