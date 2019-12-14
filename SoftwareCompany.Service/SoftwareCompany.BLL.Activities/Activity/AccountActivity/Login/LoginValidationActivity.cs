
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Base;
using SoftwareCompany.BLL.Rules.Validation.Operation.Account.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operation.Account.Exceptions;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.Login
{
    public class LoginValidationActivity : IValidationActivity<LoginRequestEvent>
    {
        private ILoginOperationValidationRule loginOperationValidation;
        public LoginValidationActivity(ILoginOperationValidationRule loginOperationValidationRule)
        {
            this.loginOperationValidation = loginOperationValidationRule;
        }

        public void Validate(LoginRequestEvent request)
        {
            ValidationResult validationResult = loginOperationValidation.IsValid(request.Login, request.Password);

            if (!validationResult.IsValid)
            {
                throw new SystemLoginValidationException(validationResult.GetErrorMessage());
            }
        }
    }
}
