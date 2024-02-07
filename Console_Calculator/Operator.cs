using System;
namespace Console_Calculator
{
	public class Operator
	{
		public bool CheckOperator(char op)
		{
			if ((op == '+') || (op == '-') || (op == '*') || (op == '/') || (op == '^'))
			{
				return true;

			}
			return false;

        }
		
	}
}

