using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectActivity.CreateProject
{
    class CreateProjectByRequest : IRequestActivity<CreateProjectRequestEvent, CreateProjectResponseEvent>
    {
        private readonly IProjectRepository _projectRepository;
        public CreateProjectByRequest(IProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        public CreateProjectResponseEvent Execute(CreateProjectRequestEvent request)
        {
            CreateProjectResponseEvent response;

            try
            {
                bool status = _projectRepository.Create(request.Project);
                response = new CreateProjectResponseEvent(status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
