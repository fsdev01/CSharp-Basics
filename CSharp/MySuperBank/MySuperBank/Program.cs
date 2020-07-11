using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was "
                + $"created for {account.Owner} with ${account.Balance}");
            try
            {
                account.MakeDeposit(-300, DateTime.Now, "Invalid Operation");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            account.MakeWithdrawl(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawl(200, DateTime.Now, "TPLINK MODEM");
            account.MakeWithdrawl(79, DateTime.Now,"Xbox Controller");

            Console.WriteLine(account.Balance);

            // Print ledger history
            Console.WriteLine(account.getAccountHistory());
        }
    }
}
