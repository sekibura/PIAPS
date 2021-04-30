using Lab5Interpretator.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Interpretator
{
    class Context
    {
        //"as a  a"
        public IExpression Evaluate(string s)
        {
            int pos = s.Length - 1;
            while (pos > 0)
            {
                if (Char.IsLetterOrDigit(s[pos]))
                    pos--;
                else
                {
                    IExpression left = Evaluate(s.Substring(0, pos));
                    IExpression right;
                    if (pos+1<=s.Length-1)
                        right = new LetterExpression(s.Substring(pos+1, s.Length-pos-1));
                    else
                        right = new LetterExpression("");

                    char value = s[pos];
                    switch (value)
                    {
                        case ' ': return new SpaceExpression(left, right);
               
                        case '-': return new HyphenExpression(left, right);

                        case '\n': return new EnterExpression(left, right); // ne rabotaet

                        case '\t': return new TabExpression(left, right);

                        case '“': return new QuotesUPExpression(left, right);

                        case '”': return new QuotesDOWNExpression(left, right);

                        default:
                            pos--;
                            break;


                    }
                }
            }
            string result = s;
            return new LetterExpression(s);
        }
    }
}
