using System;
using Humanizer;
// NuGet Package and Unit Testing Example

namespace MySuperBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pluralise words
            Console.WriteLine("car".Pluralize());
            Console.WriteLine("pant".Pluralize());
            Console.WriteLine("Octopus".Pluralize());

            // Print out a number in words
            // three thousand five hundred and one
            Console.WriteLine(3501.ToWords());


            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was "
                + $"created for {account.Owner} with ${account.Balance}");

            account.MakeWithdrawl(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawl(200, DateTime.Now, "TPLINK MODEM");
            account.MakeWithdrawl(79, DateTime.Now, "Xbox Controller");

            // Print ledger history
            Console.WriteLine(account.getAccountHistory());
        }
    }
}
