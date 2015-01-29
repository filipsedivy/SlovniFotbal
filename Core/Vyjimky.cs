using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovní_fotbal.Core
{
    class SlovniFotbalException : Exception
    {
        public SlovniFotbalException()
        {

        }

        public SlovniFotbalException(string message)
            : base(message)
        { }

        public SlovniFotbalException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
