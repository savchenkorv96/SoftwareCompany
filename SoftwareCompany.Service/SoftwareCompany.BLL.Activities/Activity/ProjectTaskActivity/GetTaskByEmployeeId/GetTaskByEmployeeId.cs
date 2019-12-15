using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetTaskByEmployeeId
{
    public class GetTaskByEmployeeId : IRequestActivity<GetTaskListByEmployeeIdRequestEvent, GetTaskListByEmployeeIdResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public GetTaskByEmployeeId(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public GetTaskListByEmployeeIdResponseEvent Execute(GetTaskListByEmployeeIdRequestEvent request)
        {
            GetTaskListByEmployeeIdResponseEvent response;

            try
            {
                IEnumerable<ProjectTask> projectTasks = _projectTaskRepository.GetTaskListByEmployeeId(request.EmployeeId);
                response = new GetTaskListByEmployeeIdResponseEvent(projectTasks);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
