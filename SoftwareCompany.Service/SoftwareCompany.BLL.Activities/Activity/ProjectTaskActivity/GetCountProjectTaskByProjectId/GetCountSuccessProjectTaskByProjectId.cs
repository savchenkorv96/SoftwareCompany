using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetCountProjectTaskByProjectId
{
    public class GetCountSuccessProjectTaskByProjectId : IRequestActivity<GetCountSuccessTaskByProjectIdRequestEvent, GetCountSuccessTaskByProjectIdResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public GetCountSuccessProjectTaskByProjectId(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public GetCountSuccessTaskByProjectIdResponseEvent Execute(GetCountSuccessTaskByProjectIdRequestEvent request)
        {
            GetCountSuccessTaskByProjectIdResponseEvent response;

            try
            {
                int countSuccessTask = _projectTaskRepository.GetCountSuccessTaskByProjectId(request.ProjectId);
                response = new GetCountSuccessTaskByProjectIdResponseEvent(countSuccessTask);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
