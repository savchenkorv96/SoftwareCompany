using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.TeamActivity.CreateTeam
{
    public class CreateTeamByRequest : IRequestActivity<CreateTeamRequestEvent, CreateTeamResponseEvent>
    {
        private readonly ITeamRepository _teamRepository;
        public CreateTeamByRequest(ITeamRepository teamRepository)
        {
            this._teamRepository = teamRepository;
        }

        public CreateTeamResponseEvent Execute(CreateTeamRequestEvent request)
        {
            CreateTeamResponseEvent response;

            try
            {
                bool status = _teamRepository.Create(request.Team);
                response = new CreateTeamResponseEvent(status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
