using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;

namespace SoftwareCompany.BLL.Rules.Validation.Operation.Account.Contract
{
    public interface ILoginOperationValidationRule
    {
        ValidationResult IsValid(string login, string password);

        ValidationResult ValidateLogin(string login);

        ValidationResult ValidatePassword(string password);
    }
}
