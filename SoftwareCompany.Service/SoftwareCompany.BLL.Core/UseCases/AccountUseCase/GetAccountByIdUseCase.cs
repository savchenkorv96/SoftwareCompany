using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions;

namespace SoftwareCompany.BLL.Core.UseCases.AccountUseCase
{
    class GetAccountByIdUseCase : IUseCase<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent>
    {
        private readonly IRequestActivity<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent> _request;

        public GetAccountByIdUseCase(IRequestActivity<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetAccountByIdResponseEvent Execute(GetAccountByIdRequestEvent request)
        {
            try
            {
                return this._request.Execute(request);
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
