using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent;

namespace SoftwareCompany.BLL.Core.UseCases.ProjectTaskUseCase
{
    public class GetCountSuccessProjectTaskByProjectIdUseCase : IUseCase<GetCountSuccessTaskByProjectIdRequestEvent, GetCountSuccessTaskByProjectIdResponseEvent>
    {
        private readonly IRequestActivity<GetCountSuccessTaskByProjectIdRequestEvent, GetCountSuccessTaskByProjectIdResponseEvent> _request;

        public GetCountSuccessProjectTaskByProjectIdUseCase(IRequestActivity<GetCountSuccessTaskByProjectIdRequestEvent, GetCountSuccessTaskByProjectIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetCountSuccessTaskByProjectIdResponseEvent Execute(GetCountSuccessTaskByProjectIdRequestEvent request)
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
