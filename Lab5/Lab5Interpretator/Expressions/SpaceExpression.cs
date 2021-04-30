using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Interpretator.Expressions
{
    class SpaceExpression : IExpression
    {
        IExpression rightValue;
        IExpression leftValue;
        public SpaceExpression(IExpression rightValue, IExpression leftValue)
        {
            this.rightValue = rightValue;
            this.leftValue = leftValue;

        }

        public string intepret()
        { 
            if(rightValue.intepret().EndsWith(" "))
                return rightValue.intepret()+leftValue.intepret();
            else
                return rightValue.intepret() + " " + leftValue.intepret();
        }   


    }
}
