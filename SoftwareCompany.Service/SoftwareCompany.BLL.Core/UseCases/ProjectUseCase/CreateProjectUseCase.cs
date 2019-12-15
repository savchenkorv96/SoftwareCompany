using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectUseCase
{
    public class CreateProjectUseCase : IUseCase<CreateProjectRequestEvent, CreateProjectResponseEvent>
    {
        private readonly IRequestActivity<CreateProjectRequestEvent, CreateProjectResponseEvent> _request;

        public CreateProjectUseCase(IRequestActivity<CreateProjectRequestEvent, CreateProjectResponseEvent> request)
        {
            this._request = request;
        }
        public CreateProjectResponseEvent Execute(CreateProjectRequestEvent request)
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
