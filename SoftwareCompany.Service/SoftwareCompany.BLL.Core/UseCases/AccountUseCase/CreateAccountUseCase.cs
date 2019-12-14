using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions;

namespace SoftwareCompany.BLL.Core.UseCases.AccountUseCase
{
    class CreateAccountUseCase : IUseCase<CreateAccountRequestEvent, CreateAccountResponseEvent>
    {
        private readonly IValidationActivity<CreateAccountRequestEvent> _createAccountValidationActivity;

        private readonly IRequestActivity<CreateAccountRequestEvent, CreateAccountResponseEvent> _request;

        public CreateAccountUseCase(IValidationActivity<CreateAccountRequestEvent> createAccountValidationActivity, IRequestActivity<CreateAccountRequestEvent, CreateAccountResponseEvent> request)
        {
            this._createAccountValidationActivity = createAccountValidationActivity;
            this._request = request;
        }
        public CreateAccountResponseEvent Execute(CreateAccountRequestEvent request)
        {
            try
            {
                _createAccountValidationActivity.Validate(request);
                return this._request.Execute(request);
            }
            catch (SystemLoginValidationException ex)
            {
                throw new SystemLoginValidationException(ex.Message, ex);
            }
            catch (MissingMemberException ex)
            {
                throw new MissingMemberException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
