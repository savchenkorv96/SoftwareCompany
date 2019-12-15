using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetEmployee
{
    public class GetEmployeeById : IRequestActivity<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeById(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public GetEmployeeByIdResponseEvent Execute(GetEmployeeByIdRequestEvent request)
        {
            GetEmployeeByIdResponseEvent response;

            try
            {
                Employee employee = _employeeRepository.GetById(request.Id);
                response = new GetEmployeeByIdResponseEvent(employee);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Id is incorrect!", ex);
            }

            return response;
        }
    }
}
