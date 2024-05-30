using System;

interface IFirstInterface
{
    void myMethod(); // Interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // Interface method
}

// New interface
interface IThirdInterface
{
    void myBestMethod(); // Abstract method
}

// Multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface, IThirdInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }

    public void myOtherMethod()
    {
        Console.WriteLine("Some other text...");
    }

    public void myBestMethod()
    {
        Console.WriteLine("My best text...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();
        myObj.myBestMethod(); // Call the new method
    }
}
