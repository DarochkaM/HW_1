// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] myNum = {10, 100, 30, 10002};
        int max = 0;
        for (int i = 0; i < myNum.Length; i++)
        {
            if (myNum[i]>=max)
            {
                max = myNum[i];
            }
            //Console.WriteLine(myNum[i]);
        }
        Console.WriteLine("max is " + max);

        // Console.WriteLine("Enter first number A: ");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number B: ");
        // int b = Convert.ToInt32(Console.ReadLine());
        
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