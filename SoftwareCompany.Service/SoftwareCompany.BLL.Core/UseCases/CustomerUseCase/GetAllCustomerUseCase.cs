using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetAllCustomerEvent;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.CustomerUseCase
{
    public class GetAllCustomerUseCase : IUseCase<GetAllCustomerRequestEvent, GetAllCustomerResponseEvent>
    {
        private readonly IRequestActivity<GetAllCustomerRequestEvent, GetAllCustomerResponseEvent> _request;

        public GetAllCustomerUseCase(IRequestActivity<GetAllCustomerRequestEvent, GetAllCustomerResponseEvent> request)
        {
            this._request = request;
        }

        public GetAllCustomerResponseEvent Execute(GetAllCustomerRequestEvent request)
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
