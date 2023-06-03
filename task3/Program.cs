// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Even/Odd check");
        Console.WriteLine("Enter number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a%2==0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        // if (a > b) 
        // {
        //     Console.WriteLine("MAX is:" + a);
        //     Console.WriteLine("HELLO");
        // }
        // else
        // {
        //     Console.WriteLine("MAX is:"+b);
        // }

    }
}