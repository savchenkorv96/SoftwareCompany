using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectActivity.GetProjectById
{
    class GetProjectById : IRequestActivity<GetProjectByIdRequestEvent, GetProjectByIdResponseEvent>
    {
        private readonly IProjectRepository _projectRepository;
        public GetProjectById(IProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        public GetProjectByIdResponseEvent Execute(GetProjectByIdRequestEvent request)
        {
            GetProjectByIdResponseEvent response;

            try
            {
                Project Project = _projectRepository.GetById(request.Id);
                response = new GetProjectByIdResponseEvent(Project);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
