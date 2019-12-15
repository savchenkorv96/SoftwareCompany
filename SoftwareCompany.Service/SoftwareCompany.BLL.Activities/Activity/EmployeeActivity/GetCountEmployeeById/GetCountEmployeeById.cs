using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetCountEmployeeByTeamIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetCountEmployeeById
{
    public class GetCountEmployeeById : IRequestActivity<GetCountEmployeeByTeamIdRequestEvent, GetCountEmployeeByTeamIdResponseEvent>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetCountEmployeeById(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public GetCountEmployeeByTeamIdResponseEvent Execute(GetCountEmployeeByTeamIdRequestEvent request)
        {
            GetCountEmployeeByTeamIdResponseEvent response;

            try
            {
                int countEmployee = _employeeRepository.GetCountEmployeeByTeamId(request.TeamId);
                response = new GetCountEmployeeByTeamIdResponseEvent(countEmployee);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Id is incorrect!", ex);
            }

            return response;
        }
    }
}
