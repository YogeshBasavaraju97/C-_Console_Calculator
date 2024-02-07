using System;
namespace Console_Calculator
{
	public class Associativity
	{
		public char AssociativityCheck(char c)
		{
			if (c == '^')
			{
                return 'R';
            }
			return 'L';
					
		}
	}
}

