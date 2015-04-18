using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovniFotbal.Core.Exceptions
{
    class DictonaryNotFoundException : Exception
    {
        public DictonaryNotFoundException(string message)
            : base(message)
        { }

        public DictonaryNotFoundException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
