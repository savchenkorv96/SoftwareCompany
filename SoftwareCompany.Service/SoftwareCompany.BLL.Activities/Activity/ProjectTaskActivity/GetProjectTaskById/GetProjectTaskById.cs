using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetProjectTaskById
{
    public class GetProjectTaskById : IRequestActivity<GetProjectTaskByIdRequestEvent, GetProjectTaskByIdResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public GetProjectTaskById(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public GetProjectTaskByIdResponseEvent Execute(GetProjectTaskByIdRequestEvent request)
        {
            GetProjectTaskByIdResponseEvent response;

            try
            {
                ProjectTask projectTask = _projectTaskRepository.GetById(request.Id);
                response = new GetProjectTaskByIdResponseEvent(projectTask);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
