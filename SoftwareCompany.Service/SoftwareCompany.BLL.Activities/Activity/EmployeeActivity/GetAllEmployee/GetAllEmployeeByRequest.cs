using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetAllEmployee
{
    public class GetAllEmployeeByRequest : IRequestActivity<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllEmployeeByRequest(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public GetAllEmployeeResponseEvent Execute(GetAllEmployeeRequestEvent request)
        {
            GetAllEmployeeResponseEvent response;

            try
            {
                IEnumerable<Employee> employee = _employeeRepository.GetAll();
                response = new GetAllEmployeeResponseEvent(employee);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("AccountId is incorrect!", ex);
            }

            return response;
        }
    }
}
