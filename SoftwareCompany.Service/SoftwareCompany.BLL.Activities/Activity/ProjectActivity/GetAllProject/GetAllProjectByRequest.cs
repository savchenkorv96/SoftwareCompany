using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectActivity.GetAllProject
{
    class GetAllProjectByRequest : IRequestActivity<GetAllProjectRequestEvent, GetAllProjectResponseEvent>
    {
        private readonly IProjectRepository _projectRepository;
        public GetAllProjectByRequest(IProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        public GetAllProjectResponseEvent Execute(GetAllProjectRequestEvent request)
        {
            GetAllProjectResponseEvent response;

            try
            {
                IEnumerable<Project> Projects = _projectRepository.GetAll();
                response = new GetAllProjectResponseEvent(Projects);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
