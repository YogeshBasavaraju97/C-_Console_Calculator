using System;
using System.Data;

namespace Calculator
{
	public class BasicCalculator
    { 
     
        public void BasicOperations(double num1, double num2,string op)
		{
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));

                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
             //Wait for the user to respond before closing.
           Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();   
        }
    
	}
}

