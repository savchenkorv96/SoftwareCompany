using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectUseCase
{
    public class GetProjectByTeamIdUseCase : IUseCase<GetProjectByTeamIdRequestEvent, GetProjectByTeamIdResponseEvent>
    {
        private readonly IRequestActivity<GetProjectByTeamIdRequestEvent, GetProjectByTeamIdResponseEvent> _request;

        public GetProjectByTeamIdUseCase(IRequestActivity<GetProjectByTeamIdRequestEvent, GetProjectByTeamIdResponseEvent> request)
        {
            this._request = request;
        }

        public GetProjectByTeamIdResponseEvent Execute(GetProjectByTeamIdRequestEvent request)
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
