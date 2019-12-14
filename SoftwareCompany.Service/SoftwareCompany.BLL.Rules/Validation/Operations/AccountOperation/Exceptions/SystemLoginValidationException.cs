using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions
{
    public class SystemLoginValidationException : Exception
    {
        public SystemLoginValidationException()
        {
        }

        public SystemLoginValidationException(string message) : base(message)
        {
        }

        public SystemLoginValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
