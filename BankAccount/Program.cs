using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            Console.WriteLine($"Initial balance is {account.Balance}");

            account.Deposit(500);
            Console.WriteLine($"Balance after deposit of 500 is {account.Balance}");

            account.Withdraw(1200);
            Console.WriteLine($"Balance after withdrawal of 1200 is {account.Balance}");

            try
            {
                account.Withdraw(2000);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Failed to withdraw: {e.Message}");
            }
        }
    }
}