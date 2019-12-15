using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.TeamUseCase
{
    public class GetAllTeamUseCase : IUseCase<GetAllTeamRequestEvent, GetAllTeamResponseEvent>
    {
        private readonly IRequestActivity<GetAllTeamRequestEvent, GetAllTeamResponseEvent> _request;

        public GetAllTeamUseCase(IRequestActivity<GetAllTeamRequestEvent, GetAllTeamResponseEvent> request)
        {
            this._request = request;
        }

        public GetAllTeamResponseEvent Execute(GetAllTeamRequestEvent request)
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
