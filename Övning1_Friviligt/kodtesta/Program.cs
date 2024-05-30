﻿using System;

// Abstract class
abstract class Animal
{
    // Abstract methods 
    public abstract void animalSound();
    public abstract void spinna();

    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// inherit from Animal
class Pig : Animal
{
    public override void animalSound()
    {
        
        Console.WriteLine("The pig says: wee wee");
    }

    public override void spinna()
    {
        
        Console.WriteLine("Grisar kan inte spinna");
    }
}


class Cat : Animal
{
    public override void animalSound()
    {
    
        Console.WriteLine("Mjau");
    }

    public override void spinna()
    {
        
        Console.WriteLine("Katten spinner");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.spinna();  // Call the new abstract method
        myPig.sleep();  // Call the regular method

        Cat myCat = new Cat(); // Create a Cat object
        myCat.animalSound();  // Call the abstract method
        myCat.spinna();  // Call the new abstract method
        myCat.sleep();  // Call the regular method
    }
}
