using System;
using System.Collections.Generic;

namespace ObjectOriented
{
    internal class Task3
    {
        public void run()
        {
            BankAccount1 account;

            // Savings Account
            account = new SavingsAccount1("Niruuuu", 420);

            account.Deposit(50000);
            account.Withdrawal(40000);

            SavingsAccount1 saving = (SavingsAccount1)account;
            saving.ApplyInterest();

            account.DisplayAccountInfo();

            Console.WriteLine("\n\n");

            // Checking Account
            account = new CheckingAccount1("Ramuuuu", 520);

            account.Deposit(15000);
            account.Withdrawal(10000);

            account.DisplayAccountInfo();
        }
    }

    // Enum
    public enum AccountType1
    {
        Generic,
        Saving,
        Current
    }

    // Base Class
    public class BankAccount1
    {
        public static string BankName;

        static BankAccount1()
        {
            BankName = "Global Trust Bank";
        }

        public string AccountName { get; set; }

        public long AccountNumber { get; }

        protected decimal Balance { get; set; }

        public AccountType1 AccountType { get; set; } = AccountType1.Generic;

        public bool IsActive { get; } = true;

        public List<string> TransactionHistory { get; } = new List<string>();

        // Constructor
        public BankAccount1(string name, long number)
        {
            AccountName = name;
            AccountNumber = number;

            TransactionHistory.Add("Account Created");
        }

        // Deposit
        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += (decimal)amount;
                TransactionHistory.Add($"Deposited: {amount}");
            }
        }

        // Withdraw
        public virtual void Withdrawal(double amount)
        {
            if (amount > 0 && (decimal)amount <= Balance)
            {
                Balance -= (decimal)amount;
                TransactionHistory.Add($"Withdrawn: {amount}");
            }
        }

        // Display
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Bank Name: {BankName}");
            Console.WriteLine($"Name: {AccountName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Balance: {Balance}");

            Console.WriteLine("\nTransaction History:");

            foreach (var item in TransactionHistory)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Savings Account
    public class SavingsAccount1 : BankAccount1
    {
        public const double InterestRate = 0.04;

        public SavingsAccount1(string name, long number)
            : base(name, number)
        {
            AccountType = AccountType1.Saving;
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * (decimal)InterestRate;

            base.Deposit((double)interest);
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Interest Rate: {InterestRate * 100}%");
        }
    }

    // Checking Account
    public class CheckingAccount1 : BankAccount1
    {
        public CheckingAccount1(string name, long number)
            : base(name, number)
        {
            AccountType = AccountType1.Current;
        }
    }
}