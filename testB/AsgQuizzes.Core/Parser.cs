using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgQuizzes.Core
{
    public class Parser
    {
        public static List<string> Parse(string expression)
        {
            List<string> tokens = new List<string>();
            
            tokens.AddRange(expression.Split(' '));
            return tokens;
        }
    }
}
