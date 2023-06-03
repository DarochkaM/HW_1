// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array = {1,2,3,4,5,6,7,8};
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]%2==0)
            {
                Console.WriteLine("even "+array[i]);
            }
        }
    }
} 

