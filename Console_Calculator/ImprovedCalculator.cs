using System;
namespace Calculator
{
	public class ImprovedCalculator
	{
        PostFixConversion postfixConversion = new PostFixConversion();
        PostFixEvaluation postFixEvaluation = new PostFixEvaluation();

        public double EvaluateExpression(string expression)
        {
            double result = 0;
            List<string> symbols = postfixConversion.InfixToPostfix(expression);
            result = postFixEvaluation.PerformEvaluation(symbols);

            return result;

        }
    }
 }

