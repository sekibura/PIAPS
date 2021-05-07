using Lab5Interpretator.Expressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab5Interpretator
{
    class Context
    {
        static int a = 0;

        //"as a  a"
        public IExpression Evaluate(string s)
        {
            a++;
            Debug.WriteLine("evaluate "+a+" = "+ s);
            int pos = s.Length - 1;
            while (pos > 0)
            {
                if (Char.IsLetterOrDigit(s[pos]))
                    pos--;
                else
                {
                    //Debug.WriteLine("|"+s.Substring(0, pos)+"|");
                    IExpression left = Evaluate(s.Substring(0, pos));
                    //IExpression left = new LetterExpression(s.Substring(0, pos));
                    
                    IExpression right;
                    if (pos+1<=s.Length-1)
                        right = new LetterExpression(s.Substring(pos+1, s.Length-pos-1));
                    else
                        right = new LetterExpression("");


                    char value = s[pos];
                    switch (value)
                    {
                        case ' ': return new SpaceExpression(left, right);//+
               
                        case '-': return new HyphenExpression(right, left);//+

                        case '\r': return new EnterExpression(right, left); //---

                        case '\t': return new TabExpression(right, left);//+-

                        case '“': return new QuotesUPExpression(right, left);//+

                        case '”': return new QuotesDOWNExpression(right, left);//+

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
