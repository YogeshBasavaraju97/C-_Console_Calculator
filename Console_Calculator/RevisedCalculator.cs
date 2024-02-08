using System;
using System.IO;
using System.Text;
namespace Console_Calculator
{
	public class RevisedCalculator
	{
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a" :
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                      result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}

