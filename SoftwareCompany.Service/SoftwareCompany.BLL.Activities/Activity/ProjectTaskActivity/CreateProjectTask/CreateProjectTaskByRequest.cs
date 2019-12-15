using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.CreateProjectTask
{
    public class CreateProjectTaskByRequest : IRequestActivity<CreateProjectTaskRequestEvent, CreateProjectTaskResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public CreateProjectTaskByRequest(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public CreateProjectTaskResponseEvent Execute(CreateProjectTaskRequestEvent request)
        {
            CreateProjectTaskResponseEvent response;

            try
            {
                bool status = _projectTaskRepository.Create(request.ProjectTask);
                response = new CreateProjectTaskResponseEvent(status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
