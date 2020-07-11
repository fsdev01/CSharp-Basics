using System;
namespace HelloWorld
{
   
    public class Car
    {
        //"Encapsulation" - which is the process of making sure that "sensitive" data is
        // hidden from users - by using the private field

        private string model; // Create a field
        private string color;
        private int year;

        // create a class constructor for the Car Class
        // The constructor should match the class name and can't have return
        // type. If you do not create a class constructor yourself.
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            this.color = modelColor;
            year = modelYear;
        }

        public Car()
        {
            model = "Mustang";
            this.color = "Red";
            year = 1969;
        }

        // Property - Setter and Getter Methods
        public string Color // Uppercase
        {
            get { return color; } // get method
            // set method - value repreents the value we assigned to the property
            set { color = value;  } 
        }


        public void fullThrottle()
        {
            Console.WriteLine("The car is going fast!");
        }

    }
}
