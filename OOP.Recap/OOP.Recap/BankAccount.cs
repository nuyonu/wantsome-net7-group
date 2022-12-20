using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Recap
{
    public static class AccountNumberGenerator
    {
        private static int accountNumber = 0;

        public static int GetAccountNumber()
        {
            return accountNumber++;
        }
    }

    public class BankAccount
    {
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            this.Transactions = new List<string>();
        }

        public BankAccount(string accountHolder, double balance)
        {
            // With static class to be more deynamic
            AccountNumber = AccountNumberGenerator.GetAccountNumber();
            AccountHolder = accountHolder;
            Balance = balance;
            this.Transactions = new List<string>();
        }


        public int AccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public double Balance { get; private set; }

        public List<string> Transactions { get; private set; }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount should be greater than 0");
            }

            this.Balance += amount;
            this.Transactions.Add($"Deposit [{amount}]");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount should be greater than 0");
            }

            if (Balance - amount < 0)
            {
                throw new Exception("Can't withdraw more than your balance.");
            }

            this.Balance -= amount;
            this.Transactions.Add($"Widraw [{amount}]");
        }

        public double GetBalance()
        {
            return this.Balance;
        }

        public List<string> GetTransactionHistory()
        {
            return this.Transactions;
        }
    }
}
