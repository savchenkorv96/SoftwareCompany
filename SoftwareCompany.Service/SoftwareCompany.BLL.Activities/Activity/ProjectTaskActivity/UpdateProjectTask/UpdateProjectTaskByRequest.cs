using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent;
using SoftwareCompany.DAL.Common.Enumerations;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.UpdateProjectTask
{
    public class UpdateProjectTaskByRequest : IRequestActivity<UpdateProjectTaskRequestEvent, UpdateProjectTaskResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public UpdateProjectTaskByRequest(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public UpdateProjectTaskResponseEvent Execute(UpdateProjectTaskRequestEvent request)
        {
            UpdateProjectTaskResponseEvent response;

            try
            {
                if (request.ProjectTask.Status == TaskStatus.Closed)
                {
                    request.ProjectTask.ActualTile = DateTime.Now;
                }
                bool status = _projectTaskRepository.Update(request.ProjectTask);
                response = new UpdateProjectTaskResponseEvent(status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
