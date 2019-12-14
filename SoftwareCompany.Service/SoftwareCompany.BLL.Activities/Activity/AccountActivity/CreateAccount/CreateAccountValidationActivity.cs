using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.CreateAccount
{
    class CreateAccountValidationActivity : IValidationActivity<CreateAccountRequestEvent>
    {
        private readonly ICreateAccountOperationValidationRule createAccountOperationValidationRule;
        public CreateAccountValidationActivity(ICreateAccountOperationValidationRule createAccountOperationValidationRule)
        {
            this.createAccountOperationValidationRule = createAccountOperationValidationRule;
        }

        public void Validate(CreateAccountRequestEvent request)
        {
            ValidationResult validationResult = createAccountOperationValidationRule.IsValid(request.Account);

            if (!validationResult.IsValid)
            {
                throw new SystemLoginValidationException(validationResult.GetErrorMessage());
            }
        }
    }
}
