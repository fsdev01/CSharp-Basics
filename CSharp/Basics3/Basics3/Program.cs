// C# Tutorial 3 - Arrays, List and Collection

using System;
using System.Collections.Generic; // import List Collection Library


namespace Basics3
{
    class Program
    {
        static void Main(string[] args)
        {
            // var - dynamic variable type
            // var - is used when you don't know the variable type at compile time
            // Alternative: List<string> names = new List<string>();

            var names = new List<string> { "<name>", "Ana", "Felipe" };

            // List<Generic> => Cup<T> such as List<int> and List<string>



            // foreach loop - traverse aeach item
            // alternative: foreach(string name in names)
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine();

            // for loop
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToLower()}");
            }


            // Modify the list contents
            Console.WriteLine();
            Console.WriteLine("Modified List");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            // Loop through list
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToLower()}");
            }
            // Count Number of Elements in the list
            Console.WriteLine($"The list has {names.Count} people in it");


            // Search, Sort and IndexOf List
            // Find the index of an item in a list
            // IndexOf will return -1, if the item doesn't exist in the list
            var index = names.IndexOf("Felipe");
            if(index == -1)
            {
                Console.WriteLine($"When the item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            // Sort List
            Console.WriteLine();
            names.Sort(); // sort in-place
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // List<T> where T can be an integer, string or other objects.

            // Fibonacci Example
            var fibonacciNumbers = new List<int> { 1, 1 };

            // Print first 20 digits

            // Fibonacci Algorithm
            // You don't want the algorithm to run when there are 20 elements in the list
            while( fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; // Last Element
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // Second Last Element
                fibonacciNumbers.Add(previous2 + previous);
            }


            // Loop through Fibonacci list
            foreach(int item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
