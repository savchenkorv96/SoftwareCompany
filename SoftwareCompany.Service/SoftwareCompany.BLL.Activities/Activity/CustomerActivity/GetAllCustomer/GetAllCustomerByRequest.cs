using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetAllCustomerEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.CustomerActivity.GetAllCustomer
{
    public class GetAllCustomerByRequest : IRequestActivity<GetAllCustomerRequestEvent, GetAllCustomerResponseEvent>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetAllCustomerByRequest(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public GetAllCustomerResponseEvent Execute(GetAllCustomerRequestEvent request)
        {
            GetAllCustomerResponseEvent response;

            try
            {
                IEnumerable<Customer> customers = _customerRepository.GetAll();
                response = new GetAllCustomerResponseEvent(customers);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
