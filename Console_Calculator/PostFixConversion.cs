using System;

namespace Console_Calculator
{
	public class PostFixConversion
	{
        Precedence precedence = new Precedence();
        Associativity associativity = new Associativity();
        Operator symbols = new Operator();
        
        //Method to convert given expression to postfix expression
        public List<string> InfixToPostfix(string s)
        {
            Stack<char> _operator = new Stack<char>();
            List<string> postfix = new List<string>();
            string num = "";

            //scanning the string s
            for (int i = 0; i < s.Length; i++)
            {
                //check for s[i] is anumber or .
                if (char.IsDigit(s[i]) || (s[i] == '.'))
                {
                    num += s[i];

                }
                else if (symbols.CheckOperator(s[i]) || (s[i] == '(') || s[i] == ')')
                {
                    if (num != "")
                    {
                        postfix.Add(num);
                        num = "";
                    }
                    if (s[i] == '(')
                    {
                        if (s[0] == '(')
                        {
                            _operator.Push(s[i]);
                        }
                        else if(symbols.CheckOperator(s[i - 1]))
                        {
                            _operator.Push(s[i]);
                        }
                        else
                        {
                            _operator.Push('*');
                            _operator.Push(s[i]);

                        }
                        
                    }
                    else if (s[i] == ')')
                    {
                        while (_operator.Count > 0 && _operator.Peek() != '(')
                        {
                            postfix.Add(_operator.Pop().ToString());
                        }
                        _operator.Pop(); // Pop '('

                    }
                    else if (symbols.CheckOperator(s[i]))
                    {
                        //while stack is non empty and if precedence of incomming operator is less than the top of stack, pop the
                        //the operator and add to postfix list
                        while (_operator.Count > 0 && (precedence.PrecedenceCheck(s[i]) < precedence.PrecedenceCheck(_operator.Peek()) ||
                       (precedence.PrecedenceCheck(s[i]) == precedence.PrecedenceCheck(_operator.Peek())) && associativity.AssociativityCheck(s[i]) == 'L'))
                        {
                            postfix.Add(_operator.Pop().ToString());
                        }
                        // if incoming operator has higher priority than top of the stact push it into stack
                        _operator.Push(s[i]);

                    }

                }
                else
                {
                    //if the element other than numbers of operator will be ignored
                    continue;
                }
            }
            while (num.Length > 0)
            {
                postfix.Add(num);
                num = "";
            }
            while (_operator.Count > 0)
            {
                postfix.Add(_operator.Pop().ToString());
            }

            return postfix;

        }
    }
}

