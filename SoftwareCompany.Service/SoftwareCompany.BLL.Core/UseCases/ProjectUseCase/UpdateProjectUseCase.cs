using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectUseCase
{
    public class UpdateProjectUseCase : IUseCase<UpdateProjectRequestEvent, UpdateProjectResponseEvent>
    {
        private readonly IRequestActivity<UpdateProjectRequestEvent, UpdateProjectResponseEvent> _request;

        public UpdateProjectUseCase(IRequestActivity<UpdateProjectRequestEvent, UpdateProjectResponseEvent> request)
        {
            this._request = request;
        }

        public UpdateProjectResponseEvent Execute(UpdateProjectRequestEvent request)
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
