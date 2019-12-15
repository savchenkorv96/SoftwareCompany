using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetAllProjectTask
{
    public class GetAllProjectTaskByRequest : IRequestActivity<GetAllProjectTaskRequestEvent, GetAllProjectTaskResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public GetAllProjectTaskByRequest(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public GetAllProjectTaskResponseEvent Execute(GetAllProjectTaskRequestEvent request)
        {
            GetAllProjectTaskResponseEvent response;

            try
            {
                IEnumerable<ProjectTask> projectTasks = _projectTaskRepository.GetAll();
                response = new GetAllProjectTaskResponseEvent(projectTasks);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
