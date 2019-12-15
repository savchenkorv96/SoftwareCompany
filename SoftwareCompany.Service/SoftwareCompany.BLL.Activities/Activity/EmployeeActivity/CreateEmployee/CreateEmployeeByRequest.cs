using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.CreateEmployee
{
    public class CreateEmployeeByRequest : IRequestActivity<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeByRequest(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public CreateEmployeeResponseEvent Execute(CreateEmployeeRequestEvent request)
        {
            CreateEmployeeResponseEvent response;

            try
            {
                bool status = _employeeRepository.Create(request.Employee);
                response = new CreateEmployeeResponseEvent(status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Unable to create employee", ex);
            }

            return response;
        }
    }
}
