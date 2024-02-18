using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsOOP {
    internal class ValidAgeException : FormatException {
        public ValidAgeException() { }

        public ValidAgeException(string message) : base(message) { }

        public ValidAgeException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
