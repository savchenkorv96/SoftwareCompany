using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class UpdateProjectTaskUseCase : IUseCase<UpdateProjectTaskRequestEvent, UpdateProjectTaskResponseEvent>
    {
        private readonly IRequestActivity<UpdateProjectTaskRequestEvent, UpdateProjectTaskResponseEvent> _request;

        public UpdateProjectTaskUseCase(IRequestActivity<UpdateProjectTaskRequestEvent, UpdateProjectTaskResponseEvent> request)
        {
            this._request = request;
        }
        public UpdateProjectTaskResponseEvent Execute(UpdateProjectTaskRequestEvent request)
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
