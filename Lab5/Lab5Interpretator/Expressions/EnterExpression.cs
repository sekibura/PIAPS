using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab5Interpretator.Expressions
{
    class EnterExpression:IExpression
    {
        IExpression rightValue;
        IExpression leftValue;
        public EnterExpression(IExpression rightValue, IExpression leftValue)
        {
            this.rightValue = rightValue;
            this.leftValue = leftValue;

        }

        public string intepret()
        {
            string s = leftValue.intepret();
            //Debug.WriteLine(value.Equals("\r\n"));
            if (leftValue.intepret().EndsWith("\n"))
            {
                //Debug.WriteLine("yes");
                return leftValue.intepret() + rightValue.intepret();
            }
            else
            {
               // Debug.WriteLine("no");
                return leftValue.intepret() + "\r\n" + rightValue.intepret();
            }
                
        }
        
    }
}
