using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class GetCountProjectTaskByProjectIdUseCase : IUseCase<GetCountTaskByProjectIdRequestEvent, GetCountTaskByProjectIdResponseEvent>
    {
        private readonly IRequestActivity<GetCountTaskByProjectIdRequestEvent, GetCountTaskByProjectIdResponseEvent> _request;

        public GetCountProjectTaskByProjectIdUseCase(IRequestActivity<GetCountTaskByProjectIdRequestEvent, GetCountTaskByProjectIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetCountTaskByProjectIdResponseEvent Execute(GetCountTaskByProjectIdRequestEvent request)
        {
            try
            {
                return this._request.Execute(request);
            }
            catch (MissingMemberException ex)
            {
                throw new MissingMemberException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
