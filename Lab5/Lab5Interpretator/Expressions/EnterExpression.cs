using System;
using System.Collections.Generic;
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
            if (rightValue.intepret().EndsWith("\n"))
                return rightValue.intepret() + leftValue.intepret();
            else
                return rightValue.intepret() + "\n" + leftValue.intepret();
        }
        
    }
}
