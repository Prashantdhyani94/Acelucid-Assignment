// DOTNET ASSIGNMENT

// 1. Print triangle - and allow user to set height of it in. Like in the following case it’s 4
//    *
//   ***
//  *****
// *******
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the height of the triangle: ");
        
        int height;
        if (int.TryParse(Console.ReadLine(), out height) && height > 0)
        {
            for (int i = 1; i <= height; i++)
            {

                for (int j = 1; j <= (height - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}

