using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Interpretator.Expressions
{
    class QuotesDOWNExpression:IExpression
    {
        IExpression rightValue;
        IExpression leftValue;
        public QuotesDOWNExpression(IExpression rightValue, IExpression leftValue)
        {
            this.rightValue = rightValue;
            this.leftValue = leftValue;

        }

        public string intepret()
        {
            if (leftValue.intepret().EndsWith("”"))
                return leftValue.intepret() + rightValue.intepret();
            else
                return leftValue.intepret() + "»" + rightValue.intepret();
        }
    }
}
