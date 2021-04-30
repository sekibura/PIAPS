using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Interpretator.Expressions
{
    class LetterExpression : IExpression
    {
        string letter;
        public LetterExpression(string letter)
        {
            this.letter = letter;
        }

        public string intepret()
        {
            return letter;
        }


    }
}
