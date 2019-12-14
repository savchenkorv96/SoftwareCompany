using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract
{
    public interface ILoginOperationValidationRule
    {
        ValidationResult IsValid(string login, string password);
        ValidationResult ValidateLogin(string login);
        ValidationResult ValidatePassword(string password);
    }
}
