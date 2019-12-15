using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetCountEmployeeByTeamIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;

namespace SoftwareCompany.BLL.Core.UseCases.EmployeeUseCase
{
    public class GetCountEmployeeByTeamIdUseCase : IUseCase<GetCountEmployeeByTeamIdRequestEvent, GetCountEmployeeByTeamIdResponseEvent>
    {
        private readonly IRequestActivity<GetCountEmployeeByTeamIdRequestEvent, GetCountEmployeeByTeamIdResponseEvent> _request;

        public GetCountEmployeeByTeamIdUseCase(IRequestActivity<GetCountEmployeeByTeamIdRequestEvent, GetCountEmployeeByTeamIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetCountEmployeeByTeamIdResponseEvent Execute(GetCountEmployeeByTeamIdRequestEvent request)
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
