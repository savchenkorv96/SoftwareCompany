using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectActivity.UpdateProject
{
    public class UpdateProjectByRequest : IRequestActivity<UpdateProjectRequestEvent, UpdateProjectResponseEvent>
    {
        private readonly IProjectRepository _projectRepository;
        public UpdateProjectByRequest(IProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        public UpdateProjectResponseEvent Execute(UpdateProjectRequestEvent request)
        {
            UpdateProjectResponseEvent response;

            try
            {
                bool Status = _projectRepository.Update(request.Project);
                response = new UpdateProjectResponseEvent(Status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
