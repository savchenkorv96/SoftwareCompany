using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;

namespace SoftwareCompany.BLL.Core.UseCases.TeamUseCase
{
    public class CreateTeamUseCase : IUseCase<CreateTeamRequestEvent, CreateTeamResponseEvent>
    {
        private readonly IRequestActivity<CreateTeamRequestEvent, CreateTeamResponseEvent> _request;

        public CreateTeamUseCase(IRequestActivity<CreateTeamRequestEvent, CreateTeamResponseEvent> request)
        {
            this._request = request;
        }

        public CreateTeamResponseEvent Execute(CreateTeamRequestEvent request)
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
