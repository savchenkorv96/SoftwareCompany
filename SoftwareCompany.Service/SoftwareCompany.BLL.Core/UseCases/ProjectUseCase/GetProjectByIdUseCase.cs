using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectUseCase
{
    public class GetProjectByIdUseCase : IUseCase<GetProjectByIdRequestEvent, GetProjectByIdResponseEvent>
    {
        private readonly IRequestActivity<GetProjectByIdRequestEvent, GetProjectByIdResponseEvent> _request;

        public GetProjectByIdUseCase(IRequestActivity<GetProjectByIdRequestEvent, GetProjectByIdResponseEvent> request)
        {
            this._request = request;
        }

        public GetProjectByIdResponseEvent Execute(GetProjectByIdRequestEvent request)
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