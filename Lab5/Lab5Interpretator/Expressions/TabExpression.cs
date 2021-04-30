using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Interpretator.Expressions
{
    class TabExpression:IExpression
    {
        IExpression rightValue;
        IExpression leftValue;
        public TabExpression(IExpression rightValue, IExpression leftValue)
        {
            this.rightValue = rightValue;
            this.leftValue = leftValue;

        }

        public string intepret()
        {
            if (rightValue.intepret().EndsWith("\t"))
                return rightValue.intepret() + leftValue.intepret();
            else
                return rightValue.intepret() + "\t" + leftValue.intepret();
        }
    }
}
