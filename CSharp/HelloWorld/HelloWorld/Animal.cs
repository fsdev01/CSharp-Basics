using System;
namespace HelloWorld
{
    
    // Abstract class - can't be used to create objects, but only inherit
    public abstract class Animal
    {
        // Abstract method - no body and must be inherited
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

    }
    

    /*
    public class Animal // Base Class (parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

    }
    */



    public class Pig : Animal // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public class Dog : Animal // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }


    // interface
    public interface IAnimal
    {
        void animalSound(); // interface method - odes not have body

    }

    // Pig implements the IAnimal interface
    public class tPig : IAnimal
    {
        public void animalSound()
        {
            //The body of animalSound() is provided jere
            Console.WriteLine("The tpig says: wee");
        }
    }
      


}
