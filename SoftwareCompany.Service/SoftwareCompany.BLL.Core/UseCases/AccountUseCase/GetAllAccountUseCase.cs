using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAllAccountEvents;

namespace SoftwareCompany.BLL.Core.UseCases.AccountUseCase
{
    public class GetAllAccountUseCase : IUseCase<GetAllAccountRequestEvent, GetAllAccountResponseEvent>
    {
        private readonly IRequestActivity<GetAllAccountRequestEvent, GetAllAccountResponseEvent> _request;

        public GetAllAccountUseCase(IRequestActivity<GetAllAccountRequestEvent, GetAllAccountResponseEvent> request)
        {
            this._request = request;
        }
        public GetAllAccountResponseEvent Execute(GetAllAccountRequestEvent request)
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
