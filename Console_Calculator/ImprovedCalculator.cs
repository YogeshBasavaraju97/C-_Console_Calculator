using System;
namespace Console_Calculator
{
	public class ImprovedCalculator
	{
        //Initialised objects 
        PostFixConversion postfixConversion = new PostFixConversion();
        PostFixEvaluation postFixEvaluation = new PostFixEvaluation();

        //Method to Evaluate the expression
        public double EvaluateExpression(string expression)
        {   //Declare variable and initisle to zero
            double result = 0;

            //Method return postfix expression in list data structure
            List<string> symbols = postfixConversion.InfixToPostfix(expression);

            //Method evaluates the postfix expression return a double data type
            result = postFixEvaluation.PerformEvaluation(symbols);

            return result;

        }
    }
 }

