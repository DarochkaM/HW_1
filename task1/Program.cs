// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number A: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number B: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        if (a > b) 
        {
            Console.WriteLine("MAX is:" + a);
        }
        else
        {
            Console.WriteLine("MAX is:"+b);
        }

    }
}