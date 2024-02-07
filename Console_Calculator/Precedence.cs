using System;

namespace Console_Calculator
{
    public class Precedence
    {
     
        //function to check the precedence
        public int PrecedenceCheck(char c)
        {

            if (c == '^')
            {
                return 3;
            }
            else if  (c == '/' || c == '*')
            {
                return 2;
            }
                
            else if (c == '+' || c == '-')
            {
                return 1;
            }

            else
            {
                return -1;
            }
                
        }
    }
}

