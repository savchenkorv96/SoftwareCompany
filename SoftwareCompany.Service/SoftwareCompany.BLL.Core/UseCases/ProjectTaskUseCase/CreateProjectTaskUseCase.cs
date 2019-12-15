using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class CreateProjectTaskUseCase : IUseCase<CreateProjectTaskRequestEvent, CreateProjectTaskResponseEvent>
    {
        private readonly IRequestActivity<CreateProjectTaskRequestEvent, CreateProjectTaskResponseEvent> _request;

        public CreateProjectTaskUseCase(IRequestActivity<CreateProjectTaskRequestEvent, CreateProjectTaskResponseEvent> request)
        {
            this._request = request;
        }
        public CreateProjectTaskResponseEvent Execute(CreateProjectTaskRequestEvent request)
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
