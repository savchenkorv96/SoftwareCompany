using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;

namespace SoftwareCompany.BLL.Core.UseCases.CustomerUseCase
{
    public class GetCustomerByIdUseCase : IUseCase<GetCustomerByIdRequestEvent, GetCustomerByIdResponseEvent>
    {
        private readonly IRequestActivity<GetCustomerByIdRequestEvent, GetCustomerByIdResponseEvent> _request;

        public GetCustomerByIdUseCase(IRequestActivity<GetCustomerByIdRequestEvent, GetCustomerByIdResponseEvent> request)
        {
            this._request = request;
        }

        public GetCustomerByIdResponseEvent Execute(GetCustomerByIdRequestEvent request)
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
