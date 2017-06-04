using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgQuizzes.Core
{
    public class Query
    {
        public static int[] ApplyRule(int limit , Func<int, bool> filter)
        {
            return Enumerable.Range(1, limit).ToList().Where(filter).ToArray();
        }
    }
}
