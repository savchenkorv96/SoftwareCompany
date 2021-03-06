﻿using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;
using SoftwareCompany.BLL.Rules.Validation.Rules.AccountRule;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation
{
    public class LoginOperationValidationRule : ILoginOperationValidationRule
    {
        private readonly LoginValidationRule loginValidationRule;
        private readonly PasswordValidationRule passwordValidationRule;

        public LoginOperationValidationRule()
        {
            this.passwordValidationRule = new PasswordValidationRule();
            this.loginValidationRule = new LoginValidationRule();
        }

        public ValidationResult IsValid(string login, string password)
        {
            List<ValidationResult> validationResultCollection = new List<ValidationResult>
            {
                ValidateLogin(login),
                ValidatePassword(password)
            };

            return new ValidationResult(validationResultCollection);
        }
        
        public ValidationResult ValidateLogin(string login)
        {
            return this.loginValidationRule.IsValid(login);
        }

        public ValidationResult ValidatePassword(string password)
        {
            return this.passwordValidationRule.IsValid(password);
        }

    }
}
