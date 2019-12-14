using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Helpers;

namespace SoftwareCompany.BLL.Rules.Validation.Rules.AccountRule
{
    class PhoneValidationRule : ValidationRuleBase
    {
        public PhoneValidationRule() : base("Your phone is not valid!")
        {
        }

        public ValidationResult IsValid(string phone)
        {
            ValidationResult validationResult = new ValidationResult();

            if (phone == null || !phone.IsNumbers())
            {
                string errorMessage = this.GetErrorMessage();
                validationResult = new ValidationResult(false, errorMessage);
            }

            return validationResult;
        }
    }
}
