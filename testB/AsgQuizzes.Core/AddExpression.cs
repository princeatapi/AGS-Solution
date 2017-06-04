using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsgQuizzes.Core
{
    public class AddExpression<T> : IExpression<T>
    {
        private T _lop;
        private T _rop;


        public AddExpression(T lop, T rop)
        {
            _lop = lop;
            _rop = rop;
        }
        public T LOp
        {
            get
            {
                return _lop;
            }
            set
            {
                _lop = value;
            }
        }

        public T ROp
        {
            get
            {
                return _rop;
            }
            set
            {
                _rop = value;
            }
        }

        public T Calculate()
        {
            return (dynamic)ROp + LOp;
        }
    }
}
