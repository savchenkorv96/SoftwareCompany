using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.TeamActivity.GetAllTeam
{
    public class GetAllTeamByRequest : IRequestActivity<GetAllTeamRequestEvent, GetAllTeamResponseEvent>
    {
        private readonly ITeamRepository _teamRepository;
        public GetAllTeamByRequest(ITeamRepository teamRepository)
        {
            this._teamRepository = teamRepository;
        }

        public GetAllTeamResponseEvent Execute(GetAllTeamRequestEvent request)
        {
            GetAllTeamResponseEvent response;

            try
            {
                IEnumerable<Team> teamList = _teamRepository.GetAll();
                response = new GetAllTeamResponseEvent(teamList);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
