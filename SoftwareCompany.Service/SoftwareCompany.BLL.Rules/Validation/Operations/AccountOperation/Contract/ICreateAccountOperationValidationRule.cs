using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract
{
    interface ICreateAccountOperationValidationRule
    {
        ValidationResult IsValid(Account account);
        ValidationResult ValidateLogin(string login);
        ValidationResult ValidatePassword(string password);
        ValidationResult ValidateEmail(string email);
        ValidationResult ValidatePhone(string phone);
    }
}
