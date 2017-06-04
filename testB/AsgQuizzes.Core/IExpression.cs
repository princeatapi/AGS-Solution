using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgQuizzes.Core
{
    public interface IExpression<T>
    {
        T LOp { get; set; }
        T ROp { get; set; }
        T Calculate();
    }
}
