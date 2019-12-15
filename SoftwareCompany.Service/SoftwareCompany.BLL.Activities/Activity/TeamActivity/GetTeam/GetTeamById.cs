using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.TeamActivity.GetTeam
{
    public class GetTeamById : IRequestActivity<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent>
    {
        private readonly ITeamRepository _teamRepository;
        public GetTeamById(ITeamRepository teamRepository)
        {
            this._teamRepository = teamRepository;
        }

        public GetTeamByIdResponseEvent Execute(GetTeamByIdRequestEvent request)
        {
            GetTeamByIdResponseEvent response;

            try
            {
                Team team = _teamRepository.GetById(request.Id);
                response = new GetTeamByIdResponseEvent(team);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Id is incorrect!", ex);
            }

            return response;
        }
    }
}
