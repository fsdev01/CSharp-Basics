using System;
using System.Collections.Generic;

namespace MySuperBank
{
    public class BankAccount
    {
        // getter method + setter method for property
        public string Number { get; set; } // Account Number
        public string Owner { get; set; } // Owner Name
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            } } // Account Balance


        public List<Transaction> allTransactions = new List<Transaction>();

        // Seed value for the account number
        private static int accountNumberSeed = 123456789;

        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposit(initalBalance,DateTime.Now,"Opening Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            // Validation Rule: Deposit must be >$0
            if (amount <= 0)
            {
                
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {

            // Validation Rule : Withdraw positive amount
            if( amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be positive");
            }

            // Validation Rule: Don't allow overdraft
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawl");
            }


            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string getAccountHistory()
        {
            // String Builder - Efficient way to concatenate strings
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            // Use tabs to make column spaces spread out evenly
            report.AppendLine("Date\t\tAmount\tBalance\t\tNote");
            foreach(var item in allTransactions)
            {
                balance = balance + item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t\t{item.Notes}");
            }

            return report.ToString();
        }


    }
}
