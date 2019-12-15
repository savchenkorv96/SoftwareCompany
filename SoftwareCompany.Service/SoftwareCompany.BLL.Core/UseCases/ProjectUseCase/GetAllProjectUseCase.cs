using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectUseCase
{
    public class GetAllProjectUseCase : IUseCase<GetAllProjectRequestEvent, GetAllProjectResponseEvent>
    {
        private readonly IRequestActivity<GetAllProjectRequestEvent, GetAllProjectResponseEvent> _request;

        public GetAllProjectUseCase(IRequestActivity<GetAllProjectRequestEvent, GetAllProjectResponseEvent> request)
        {
            this._request = request;
        }
        public GetAllProjectResponseEvent Execute(GetAllProjectRequestEvent request)
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
