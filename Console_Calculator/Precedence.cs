using System;
namespace Calculator
{
    public class Precedence
    {
        public Precedence()
        {
        }
        //function to check the precedence
        public int PrecedenceCheck(char c)
        {

            if (c == '/' || c == '*')
                return 2;
            else if (c == '+' || c == '-')
                return 1;
            else
                return -1;
        }
    }
}

