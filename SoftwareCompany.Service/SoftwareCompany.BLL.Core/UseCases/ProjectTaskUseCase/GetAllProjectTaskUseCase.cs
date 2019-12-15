using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class GetAllProjectTaskUseCase : IUseCase<GetAllProjectTaskRequestEvent, GetAllProjectTaskResponseEvent>
    {
        private readonly IRequestActivity<GetAllProjectTaskRequestEvent, GetAllProjectTaskResponseEvent> _request;

        public GetAllProjectTaskUseCase(IRequestActivity<GetAllProjectTaskRequestEvent, GetAllProjectTaskResponseEvent> request)
        {
            this._request = request;
        }
        public GetAllProjectTaskResponseEvent Execute(GetAllProjectTaskRequestEvent request)
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
