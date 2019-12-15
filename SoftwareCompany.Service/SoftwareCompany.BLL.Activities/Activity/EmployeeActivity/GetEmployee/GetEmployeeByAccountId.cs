using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetEmployee
{
    public class GetEmployeeByAccountId : IRequestActivity<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByAccountId(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public GetEmployeeByAccountIdResponseEvent Execute(GetEmployeeByAccountIdRequestEvent request)
        {
            GetEmployeeByAccountIdResponseEvent response;

            try
            {
                Employee employee = _employeeRepository.GetEmployeeByAccountId(request.AccountId);
                response = new GetEmployeeByAccountIdResponseEvent(employee);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("AccountId is incorrect!", ex);
            }

            return response;
        }
    }
}
