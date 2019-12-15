using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;

namespace SoftwareCompany.BLL.Core.UseCases.EmployeeUseCase
{
    public class GetAllEmployeeUseCase : IUseCase<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent>
    {
        private readonly IRequestActivity<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent> _request;

        public GetAllEmployeeUseCase(IRequestActivity<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent> request)
        {
            this._request = request;
        }
        public GetAllEmployeeResponseEvent Execute(GetAllEmployeeRequestEvent request)
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
