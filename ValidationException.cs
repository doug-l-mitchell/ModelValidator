using System;
using System.Collections.Generic;

namespace ModelHelper
{
    public class ValidationException : Exception
    {
        public IEnumerable<string> Errors { get; private set; }

        public ValidationException(string message, IEnumerable<string> validationErrors) : base(message)
        {
            Errors = validationErrors;
        }

        public ValidationException(IEnumerable<string> validationErrors) : this("Validation failed", validationErrors)
        {}
    }
}
