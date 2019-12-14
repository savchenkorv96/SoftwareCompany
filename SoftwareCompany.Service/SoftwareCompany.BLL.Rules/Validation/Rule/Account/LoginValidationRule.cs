using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Helpers;

namespace SoftwareCompany.BLL.Rules.Validation.Rule.Account
{
    class LoginValidationRule : ValidationRuleBase
    {
        public LoginValidationRule() : base("Login must be a string composed of letters or digits.")
        {
        }

        public ValidationResult IsValid(string login)
        {
            ValidationResult validationResult = new ValidationResult();

            if (login == null || !login.IsStringWithNumbers())
            {
                string errorMessage = this.GetErrorMessage();
                validationResult = new ValidationResult(false, errorMessage);
            }

            return validationResult;
        }
    }
}
