using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetAllCustomerEvent;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.CustomerActivity.GetCustomer
{
    public class GetCustomerById : IRequestActivity<GetCustomerByIdRequestEvent, GetCustomerByIdResponseEvent>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerById(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public GetCustomerByIdResponseEvent Execute(GetCustomerByIdRequestEvent request)
        {
            GetCustomerByIdResponseEvent response;

            try
            {
                Customer customer = _customerRepository.GetById(request.Id);
                response = new GetCustomerByIdResponseEvent(customer);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
