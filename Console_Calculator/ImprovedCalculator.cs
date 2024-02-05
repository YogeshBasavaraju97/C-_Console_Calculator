using System;
namespace Calculator
{
	public class ImprovedCalculator
	{
        //Initialised objects
        PostFixConversion postfixConversion = new PostFixConversion();
        PostFixEvaluation postFixEvaluation = new PostFixEvaluation();

        //function to Evaluate the expression
        public double EvaluateExpression(string expression)
        {
            double result = 0;
            List<string> symbols = postfixConversion.InfixToPostfix(expression);
            result = postFixEvaluation.PerformEvaluation(symbols);

            return result;

        }
    }
 }

