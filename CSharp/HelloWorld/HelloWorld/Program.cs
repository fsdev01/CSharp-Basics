using System; // use classes fom System namespace
using System.Linq; // 

namespace HelloWorld // organise code - container for classes
{

    enum Months
    {
        Janurary, // 0
        February, // 1
        March=6,    // 6
        April,    // 7
        May,      //8
        June,     //9
        July     // 10
    }


    class Program // container for methods and data
    {
        //enum - special "class" - group of read-only constants
        enum Level
        {
            Low,
            Medium,
            High
        }


        static void Main(string[] args)
        {

            //methodOne();

            myMethod("Sweden", "Stockholm");
            // Named Arguments key:value
            myMethod(city: "Melbourne", country: "Australia");
            myMethod2();

            Console.WriteLine(PlusMethod(8, 5));
            Console.WriteLine(PlusMethod(4.3, 6.26));


            Car myObj1 = new Car();
            myObj1.Color = "white";
            Console.WriteLine(myObj1.Color);
            myObj1.fullThrottle();

            Person p1 = new Person();
            p1.Name = "Liam"; // Update field using the "Name" property
            Console.WriteLine(p1.Name); // Get field using the "Name" property\

            Truck t1 = new Truck(); // create a truck
            t1.honk();

            //Animal myAnimal = new Animal(); // Create a Animal object
            Animal myPig = new Pig(); // Create a Pig object
            Animal myDog = new Dog(); // Create a Dog Object

            // All print: "The aniimal makes a sound"
            //myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            tPig thePig = new tPig(); // Create a Pig Object
            thePig.animalSound();


            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            int myNum = (int)Months.Janurary;
            Console.WriteLine(myNum);

            int myNum2 = (int)Months.April;
            Console.WriteLine(myNum2);


            switch(myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }


            
            try
            {
                int[] temp = { 1, 2, 3 };
                Console.WriteLine(temp[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            checkAge(20); // throw the exception
        }



        static void methodOne()
        {
            /* Console is a class of System namespace
            writeLine is a method of Console class
            WriteLine: Outputs a new Line */
            Console.WriteLine("Hello World!");

            // Write does not ouptut new line
            Console.Write("Hello World 2");
            Console.WriteLine("I Will print on the same line");

            // Variable Types: int, double, char, string and bool
            // Declare Variable: type variableName = value;

            string name = "John";
            Console.WriteLine("Hello" + name);

            int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum);

            const double PI = 3.14159;

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);



            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            bool isCSharpFun = true;
            Console.WriteLine(isCSharpFun);

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            // In C#: Two types of casting
            // Implicit Casting (automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double

            //Explicit Casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            double myD = 9.78;
            int myI = (int)myD;
            Console.WriteLine(myI);


            //Prompt
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); // String to Int
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine(10 / 3);

            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));


            string txt = "AbC";
            Console.WriteLine(txt + txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string firstName = "John";
            string lastName = "Doe";
            string fullname = string.Concat(firstName, lastName);
            Console.WriteLine(fullname);


            // String Interpolaton
            string name2 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name2);

            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("e"));


            string name3 = "John Doe";
            int charPos = name3.IndexOf("D");
            string lastPart = name3.Substring(charPos);
            Console.WriteLine(lastPart);


            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good Day");

            }
            else if (time < 20)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }


            int day = 20;
            string result1 = (day < 18) ? "Good Day." : "Good Evening.";
            Console.WriteLine(result1);


            day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Keywords for Loop: break and continue


            // arrays
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            for (i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            int[] numb = { 10, 20, 30, 40 };
            //Array.Sort(numb); // sort numbers
            foreach (int item in numb)
            {
                Console.WriteLine(item);
            }
            //using System.Linq;
            Console.WriteLine(numb.Sum());
            Console.WriteLine(numb.Max());
            Console.WriteLine(numb.Min());

        }


        static void myMethod(string country,string city)
        {
            //Console.WriteLine("I just got executed!");
            Console.WriteLine("Country: " + country);
        }

        static void myMethod2(string child1="Liam",string child2="Jenny",string child3="John")
        {
            Console.WriteLine(child3);
        }

        // Method overloading - multiple methods with the same name but different parameters
        // int MyMethod(int x)
        // float MyMethod(float x)
        // double MyMethod(double x, double y)
        // Multiple methods can have the same name as long as the number and/or type of parameters are different.


        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }


        // OOP - DRY - Don't Repeat Yourself


        static void checkAge(int age)
        {
            if( age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
    }


}