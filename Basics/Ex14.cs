using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    class BankAccount
    {
        private string AccountNumber { get; set; }
        private double Balance { get; set; }
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
    }
    internal class Ex14
    {
        public static void Run()
        {
            BankAccount account = new BankAccount("123456789", 1000.0);
            account.Deposit(500.0);
            account.Withdraw(200.0);
            account.DisplayBalance();
        }
    }
}
