using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovniFotbal.Core.Exceptions
{
    class TextShortException : Exception
    {
        public TextShortException(string message)
            : base(message)
        { }

        public TextShortException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
