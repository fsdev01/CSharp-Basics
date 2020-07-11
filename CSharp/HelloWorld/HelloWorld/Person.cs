using System;
namespace HelloWorld
{
    public class Person
    {
        private string name; // field
        public string Name // property - uppercase of the field name
        {
            get { return name; } // get method
            set { name = value;  } // set method
            
        }

        // Alternative - ShortHand to define set and get methods for property
        // public string Name { get; set; }
    

    }
}
