using System;
namespace Calculator
{
	public class ImprovedOperations
	{
        public double DoOperation(double num1, double num2, string op)
        {
            SaveResult print = new SaveResult();
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
            
        }
    }
}

