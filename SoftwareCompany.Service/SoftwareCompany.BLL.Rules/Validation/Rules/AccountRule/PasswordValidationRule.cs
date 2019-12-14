using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Helpers;

namespace SoftwareCompany.BLL.Rules.Validation.Rules.AccountRule
{
    public class PasswordValidationRule : ValidationRuleBase
    {
        public PasswordValidationRule() : base("Password must be a string composed of: letters, digits, _")
        {
        }

        public ValidationResult IsValid(string password)
        {
            ValidationResult validationResult = new ValidationResult();

            if (password == null || !password.IsStringWithNumbersAndUnderscores())
            {
                string errorMessage = this.GetErrorMessage();
                validationResult = new ValidationResult(false, errorMessage);
            }

            return validationResult;
        }
    }
}
