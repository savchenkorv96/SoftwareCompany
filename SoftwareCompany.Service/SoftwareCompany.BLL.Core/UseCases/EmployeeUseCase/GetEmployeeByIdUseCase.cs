using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;

namespace SoftwareCompany.BLL.Core.UseCases.EmployeeUseCase
{
    public class GetEmployeeByIdUseCase : IUseCase<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent>
    {
        private readonly IRequestActivity<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent> _request;

        public GetEmployeeByIdUseCase(IRequestActivity<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent> request)
        {
            this._request = request;
        }
        public GetEmployeeByIdResponseEvent Execute(GetEmployeeByIdRequestEvent request)
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
