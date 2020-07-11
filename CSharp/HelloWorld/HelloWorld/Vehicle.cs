using System;
namespace HelloWorld
{
    public class Vehicle  // base class - parent
    {
        public string brand = "Ford"; // Vehicle field
        public void honk()            // Vehicle method
        {
            Console.WriteLine("Tuutm, tuut!");
        }
        public Vehicle()
        {
        }
    }

    public class Truck : Vehicle // derived class
    {
        public string modelName = "Mustang";
    }
}
