using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab5Interpretator.Expressions
{
    class SpaceExpression : IExpression
    {
        IExpression rightValue;
        IExpression leftValue;
        public SpaceExpression(IExpression leftValue , IExpression rightValue)
        {
            this.rightValue = rightValue;
            this.leftValue = leftValue;

        }

        public string intepret()
        {
            //Debug.WriteLine("space");
            if(leftValue.intepret().EndsWith(" "))
                return leftValue.intepret()+rightValue.intepret();
            else
                return leftValue.intepret() + " " + rightValue.intepret();
        }   


    }
}
