// C# Tutorial 2 - Conditional Branches and Loop

// import library - group of classes
using System;

// namespace refers to group of related classes
// You can have either:
// (1) 1 class per namespace or
// (2) a group of related classes under a single namespace
namespace Basics2
{
    class Program
    {
        // Point of entry for program
        // args represent optional array of arguments
        static void Main(string[] args)
        {
            // Concept 1: Conditional Statements
            //ExploreIf();

            // Concept 2: Loops
            // While Loops
            // while(true) -> infinite loop (if you don't include "break")
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++; // counter = counter + 1;
            }

            //for loop
            // index = 0 is the initaliser
            // index < 2; condition
            // index++; is the incrementer/iterator
            for(int index = 0; index < 2; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            // Combine Branches and Loops
            // Find the sum of all integers 1 through 20 that are divisible by 3
            int sum = 0;
            for(int i = 1; i < 21; i++)
            {
                // Divisible by 3 
                if(i % 3 == 0)
                {
                    sum += i;
                    Console.WriteLine($"The number {i} is divisible by 3");
                }
            }
            Console.WriteLine($"The sum is {sum}");
            

        }

        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");

            }
        }
    }
}
