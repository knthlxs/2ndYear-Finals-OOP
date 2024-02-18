using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsOOP {
    internal class ValidContactException : FormatException {
        public ValidContactException() { }

        public ValidContactException(string message) : base(message) { }

        public ValidContactException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
