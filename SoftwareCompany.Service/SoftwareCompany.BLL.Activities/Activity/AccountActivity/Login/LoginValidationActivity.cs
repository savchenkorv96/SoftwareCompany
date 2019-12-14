
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.Login
{
    public class LoginValidationActivity : IValidationActivity<LoginRequestEvent>
    {
        private readonly ILoginOperationValidationRule _loginOperationValidation;
        public LoginValidationActivity(ILoginOperationValidationRule loginOperationValidationRule)
        {
            this._loginOperationValidation = loginOperationValidationRule;
        }

        public void Validate(LoginRequestEvent request)
        {
            ValidationResult validationResult = _loginOperationValidation.IsValid(request.Login, request.Password);

            if (!validationResult.IsValid)
            {
                throw new SystemLoginValidationException(validationResult.GetErrorMessage());
            }
        }
    }
}
