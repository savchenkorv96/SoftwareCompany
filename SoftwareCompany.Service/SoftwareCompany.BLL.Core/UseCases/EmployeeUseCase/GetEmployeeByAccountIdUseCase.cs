using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;

namespace SoftwareCompany.BLL.Core.UseCases.EmployeeUseCase
{
    public class GetEmployeeByAccountIdUseCase : IUseCase<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent>
    {
        private readonly IRequestActivity<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent> _request;

        public GetEmployeeByAccountIdUseCase(IRequestActivity<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetEmployeeByAccountIdResponseEvent Execute(GetEmployeeByAccountIdRequestEvent request)
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
