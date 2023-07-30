using System;

namespace BankAccount
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient balance for this withdrawal");
            }

            balance -= amount;
        }
    }

}