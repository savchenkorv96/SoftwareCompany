using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectActivity.GetProjectByTeamId
{
    public class GetProjectByTeamId : IRequestActivity<GetProjectByTeamIdRequestEvent, GetProjectByTeamIdResponseEvent>
    {
        private readonly IProjectRepository _projectRepository;
        public GetProjectByTeamId(IProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        public GetProjectByTeamIdResponseEvent Execute(GetProjectByTeamIdRequestEvent request)
        {
            GetProjectByTeamIdResponseEvent response;

            try
            {
                IEnumerable<Project> Projects = _projectRepository.GetProjectListByTeamId(request.TeamId);
                response = new GetProjectByTeamIdResponseEvent(Projects);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
