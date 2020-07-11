using System;
using Humanizer;
namespace MySuperBank2
{
    public class Transaction
    {
        public decimal Amount { get; }
        public string AmountForHumans{
            get
            {
                // Ignore the decimal - force cast int(Amount)
                return ((int)Amount).ToWords();
            }
        }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
