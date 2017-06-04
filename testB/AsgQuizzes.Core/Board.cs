using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgQuizzes.Core
{
    public class Board
    {
        const string ROW_SEPARATOR = "\r\n-----------\r\n";
        const string SPACE = " ";

        public string Generate(string input)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine();

            for(int i = 0 ; i < input.Length ; i++)
            {
                if (i > 1 && i % 3 == 0)
                    builder.Append(ROW_SEPARATOR);
                builder.Append(SPACE + char.ToUpperInvariant(input[i]) + SPACE);
                if (i % 3 < 2) builder.Append("|");
            }
            builder.AppendLine();
            return builder.ToString();
        }
    }
}
