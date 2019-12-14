using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;
using SoftwareCompany.BLL.Rules.Validation.Rules.AccountRule;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation
{
    public class CreateAccountOperationValidationRule : ICreateAccountOperationValidationRule
    {
        private readonly LoginValidationRule _loginValidationRule;
        private readonly PasswordValidationRule _passwordValidationRule;
        private readonly EmailValidationRule _emailValidationRule;
        private readonly PhoneValidationRule _phoneValidationRule;

        public CreateAccountOperationValidationRule()
        {
            this._passwordValidationRule = new PasswordValidationRule();
            this._loginValidationRule = new LoginValidationRule();
            this._emailValidationRule = new EmailValidationRule();
            this._phoneValidationRule = new PhoneValidationRule();
        }

        public ValidationResult IsValid(Account account)
        {

            List<ValidationResult> validationResultCollection = new List<ValidationResult>
            {
                ValidateLogin(account.Login),
                ValidatePassword(account.Password)
            };

            return new ValidationResult(validationResultCollection);
        }

        public ValidationResult ValidateEmail(string email)
        {
            return this._emailValidationRule.IsValid(email);
        }

        public ValidationResult ValidateLogin(string login)
        {
            return this._loginValidationRule.IsValid(login);
        }

        public ValidationResult ValidatePassword(string password)
        {
            return this._passwordValidationRule.IsValid(password);
        }

        public ValidationResult ValidatePhone(string phone)
        {
            return this._phoneValidationRule.IsValid(phone);
        }
    }
}
