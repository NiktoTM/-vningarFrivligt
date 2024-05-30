using System;

// Interface
interface IAnimal
{
    void animalSound(); 
}

class Pig : IAnimal
{
    public void animalSound()
    {
        
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : IAnimal
{
    public void animalSound()
    {
        
        Console.WriteLine("The dog says: voff");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();

        Dog myDog = new Dog();  // Create a Dog object
        myDog.animalSound();
    }
}
