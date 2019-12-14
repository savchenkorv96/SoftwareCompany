using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions
{
    public class SystemCreateAccountValidationException : Exception
    {
        public SystemCreateAccountValidationException()
        {
        }

        public SystemCreateAccountValidationException(string message) : base(message)
        {
        }

        public SystemCreateAccountValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
