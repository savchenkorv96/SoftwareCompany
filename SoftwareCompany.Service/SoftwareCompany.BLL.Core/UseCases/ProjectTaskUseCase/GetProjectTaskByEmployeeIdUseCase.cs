using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class GetProjectTaskByEmployeeIdUseCase : IUseCase<GetTaskListByEmployeeIdRequestEvent, GetTaskListByEmployeeIdResponseEvent>
    {
        private readonly IRequestActivity<GetTaskListByEmployeeIdRequestEvent, GetTaskListByEmployeeIdResponseEvent> _request;

        public GetProjectTaskByEmployeeIdUseCase(IRequestActivity<GetTaskListByEmployeeIdRequestEvent, GetTaskListByEmployeeIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetTaskListByEmployeeIdResponseEvent Execute(GetTaskListByEmployeeIdRequestEvent request)
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
