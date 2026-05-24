using System;

namespace LabTask1
{
    // Enum for Account Type
    public enum AccountType
    {
        Generic,
        Saving,
        Current,
        Business
    }

    internal class Task2
    {
        public void Run()
        {
            // Creating account
            BankAccounts account = new BankAccounts("Samman Thapa Chhetri", 174327614);

            // Setting account type
            account.AccountType = AccountType.Saving;

            // Deposit money
            account.Deposit(50000);

            // Withdraw money
            account.Withdrawal(20000);

            // Display account details
            account.DisplayAccountInfo();
        }
    }

    public class BankAccounts
    {
        // Static Property
        public static string BankName { get; private set; }

        // Static Constructor
        static BankAccounts()
        {
            BankName = "Global Trust Bank";
        }

        // Properties
        public string AccountName { get; set; }

        public long AccountNumber { get; }

        protected decimal Balance { get; set; }

        public AccountType AccountType { get; set; } = AccountType.Generic;

        public bool IsActive { get; } = true;

        public List<string> TransactionHistory { get; } = new List<string>();

        // Constructor
        public BankAccounts(string accountName, long accountNumber)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            Balance = 0;

            TransactionHistory.Add("Account created successfully.");
        }

        // Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                TransactionHistory.Add($"Deposited Rs. {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Withdrawal Method
        public void Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else
            {
                Balance -= amount;
                TransactionHistory.Add($"Withdrawn Rs. {amount}");
            }
        }

        // Display Account Info
        public void DisplayAccountInfo()
        {
            Console.WriteLine(" Account Details");
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Account Holder: " + AccountName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Balance: Rs. " + Balance);
            Console.WriteLine("Account Active: " + IsActive);

            Console.WriteLine("\n\n Transaction History");

            foreach (string transaction in TransactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
 