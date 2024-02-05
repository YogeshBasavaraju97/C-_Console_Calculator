using System;
namespace Calculator
{
	public class PostFixConversion
	{
        Precedence precedence = new Precedence();
		public PostFixConversion()
		{
		}
        public List<string> InfixToPostfix(string s)
        {
            Stack<char> _operator = new Stack<char>();
            List<string> symbols = new List<string>();
            string num = " ";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) || (s[i] == '.'))
                {
                    num += s[i];

                }

                else if ((s[i] == '+') || (s[i] == '-') || (s[i] == '*') || (s[i] == '/') || (s[i] == '^'))
                {
                    symbols.Add(num);
                    num = " ";

                    while (_operator.Count > 0 && (precedence.PrecedenceCheck(s[i]) < precedence.PrecedenceCheck(_operator.Peek()) ||
                        (precedence.PrecedenceCheck(s[i]) == precedence.PrecedenceCheck(_operator.Peek()))))
                    {
                        symbols.Add(_operator.Pop().ToString());
                    }

                    _operator.Push(s[i]);
                }
                else
                {
                    continue;
                }
            }
            while (num.Length > 0)
            {
                symbols.Add(num);
                num = "";
            }
            while (_operator.Count > 0)
            {
                symbols.Add(_operator.Pop().ToString());
            }

            return symbols;

        }
    }
}

