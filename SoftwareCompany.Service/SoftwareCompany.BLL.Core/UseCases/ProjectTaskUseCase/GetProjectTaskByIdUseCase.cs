using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class GetProjectTaskByIdUseCase : IUseCase<GetProjectTaskByIdRequestEvent, GetProjectTaskByIdResponseEvent>
    {
        private readonly IRequestActivity<GetProjectTaskByIdRequestEvent, GetProjectTaskByIdResponseEvent> _request;

        public GetProjectTaskByIdUseCase(IRequestActivity<GetProjectTaskByIdRequestEvent, GetProjectTaskByIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetProjectTaskByIdResponseEvent Execute(GetProjectTaskByIdRequestEvent request)
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
