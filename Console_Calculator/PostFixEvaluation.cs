using System;
namespace Console_Calculator
{
	public class PostFixEvaluation
	{
        //Declaration of the object ImprovedOperations
        ImprovedOperations performOperations = new ImprovedOperations();
        
        //function to evaluate the postfix expression
        public double PerformEvaluation(List<string> symbols)
        {
            Stack<double> operands = new Stack<double>();
            double defaultValue = 0.0;
            double result = double.NaN;
            for (int i = 0; i < symbols.Count; i++)
            {
                if (double.TryParse(symbols[i], out defaultValue))
                {
                    operands.Push(Convert.ToDouble(symbols[i]));
                }
                else
                {
                    double num2 = operands.Pop();
                    double num1 = operands.Pop();
                    result = performOperations.DoOperation(num1, num2, symbols[i]);
                    operands.Push(result);
                }
            }
            return result;
        }
    }
}

