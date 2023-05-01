using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    [Serializable]
    public class NegativeException : Exception
    {
        public NegativeException()
        { }

        public NegativeException(string message)
            : base(message)
        { }

        public NegativeException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }

    [Serializable]
    public class UnexistingException : Exception
    {
        public UnexistingException()
        { }

        public UnexistingException(string message)
            : base(message)
        { }

        public UnexistingException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
