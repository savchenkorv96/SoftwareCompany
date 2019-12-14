using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Helpers;

namespace SoftwareCompany.BLL.Rules.Validation.Rules.AccountRule
{
    class EmailValidationRule : ValidationRuleBase
    {
        public EmailValidationRule() : base("Your email is not valid!")
        {
        }

        public ValidationResult IsValid(string email)
        {
            ValidationResult validationResult = new ValidationResult();

            if (email == null || !email.IsEmail())
            {
                string errorMessage = this.GetErrorMessage();
                validationResult = new ValidationResult(false, errorMessage);
            }

            return validationResult;
        }
    }
}
