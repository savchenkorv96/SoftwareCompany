using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetCountProjectTaskByProjectId
{
    public class GetCountProjectTaskByProjectId : IRequestActivity<GetCountTaskByProjectIdRequestEvent, GetCountTaskByProjectIdResponseEvent>
    {
        private readonly IProjectTaskRepository _projectTaskRepository;
        public GetCountProjectTaskByProjectId(IProjectTaskRepository projectTaskRepository)
        {
            this._projectTaskRepository = projectTaskRepository;
        }

        public GetCountTaskByProjectIdResponseEvent Execute(GetCountTaskByProjectIdRequestEvent request)
        {
            GetCountTaskByProjectIdResponseEvent response;

            try
            {
                int countSuccessTask = _projectTaskRepository.GetCountTaskByProjectId(request.ProjectId);
                response = new GetCountTaskByProjectIdResponseEvent(countSuccessTask);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Data is incorrect!", ex);
            }

            return response;
        }
    }
}
