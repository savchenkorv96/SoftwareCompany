using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.TeamUseCase
{
    public class GetTeamByIdUseCase : IUseCase<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent>
    {
        private readonly IRequestActivity<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent> _request;

        public GetTeamByIdUseCase(IRequestActivity<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetTeamByIdResponseEvent Execute(GetTeamByIdRequestEvent request)
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
