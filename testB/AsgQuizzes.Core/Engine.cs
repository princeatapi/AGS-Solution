using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgQuizzes.Core
{
    public class Engine<T>
    {
        public static bool IsNumeric(string s)
        {
            foreach(char c in s )
            {
                if (!char.IsDigit(c) && c != '.') return false;
            }
            return true;
        }

        public static T GetValue<T>(String value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
        public static T PostFix(List<string> tokens)
        {
            T result = default(T);
            Stack<string> stack = new Stack<string>();


            tokens.ForEach(e => { 
            
                if(IsNumeric(e))
                {
                    stack.Push(e);
                }
                else
                {
                    if (stack.Count < 2)
                        throw new ArgumentException("Invalid Expression..");
                    switch(e)
                    {
                        case "+":
                            stack.Push(new AddExpression<T>(GetValue<T>(stack.Pop()), GetValue<T>(stack.Pop())).Calculate().ToString());
                            break;
                        case "*":
                              stack.Push(new ProductExpression<T>(GetValue<T>(stack.Pop()), GetValue<T>(stack.Pop())).Calculate().ToString());
                            break;

                        default:
                            throw new Exception("Invalid Token..");
                    }
                }
            
            });
            result = GetValue<T>(stack.Pop());
            return result;
        }
    }
}
