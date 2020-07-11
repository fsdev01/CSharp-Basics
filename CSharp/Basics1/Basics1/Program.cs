// C# - Tutorial 1 - Variables, Strings and Arithmetic Operations

// Import System Library - group of classes
using System;

// namespace - group related classes
namespace Basics1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Basics of Strings
            string firstFriend = "Scott";
            string secondFriend = "Kendra";
            // String Interpolation
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            // String Property - "length"
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            // Trim Methods
            string greeting = "     Hello World!        ";
            Console.WriteLine();
            Console.WriteLine($"[{greeting}]");

            // TrimStart - removing leading whitespaces
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            // TrimEnd - remove trailing whitespaces
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            // Trim() - remove both leading and trailing whitespaces
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // Replace Method
            Console.WriteLine();
            string sayHello = "Hello World";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Kendra");
            Console.WriteLine(sayHello);

            // Convert entire string to lowercase or uppercase
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // Searching Strings
            string songLyrics = "You say goodbye, and I say hello";
            // Return True - goodbye is present in the string
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // StartsWith - search for substring
            var result = songLyrics.StartsWith("You");
            Console.WriteLine(result);

            // Numbers and Integers
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            int e = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            Console.WriteLine(e);

            // Integer division always output integer
            // The remainder is truncated
            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            // Outputs "3" instead of 3.66667
            Console.WriteLine(d);


            // Extract the remainder
            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c; // quotient
            e = (a + b) % c; // remainder
            Console.WriteLine($"quotient: {d} \t divisor:{c} \t remainder: {e}");

            // Max and Min Integer Value
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            // Overflow or underflow, operation will wrap around to smallest value
            int over = max + 3;
            Console.WriteLine($"An example of overflow: 3 + {max} = {over}");

            // FLoating point represents a non-integer number
            double x = 5;
            double y = 4;
            double z = 2;
            double w = (x + y) / z; // result: 4.5
            Console.WriteLine(w);

            // Decimal Data Type
            // Has a smaller range, but greater precision (e.g. number of decimal places) than double
            // Decimal - Range of Values
            decimal minD = decimal.MinValue;
            decimal maxD = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is: {minD} to {maxD}");

            // Comparision of Precision
            // Precision of double
            double p1 = 1.0;
            double p2 = 3.0;
            Console.WriteLine($"Double Precision: 1.0/3.0 = ${p1 / p2}");

            // Preicison of decimal
            // "M" suffix indicates that a constant should use decimal type
            decimal p3 = 1.0M;
            decimal p4 = 3.0M;
            Console.WriteLine($"Decimal Precision: 1.0M/3.0M = ${p3 / p4}");





        }
    }
}
