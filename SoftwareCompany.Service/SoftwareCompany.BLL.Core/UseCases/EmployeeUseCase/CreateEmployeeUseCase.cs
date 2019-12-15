using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;

namespace SoftwareCompany.BLL.Core.UseCases.EmployeeUseCase
{
    public class CreateEmployeeUseCase : IUseCase<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent>
    {
        private readonly IRequestActivity<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent> _request;

        public CreateEmployeeUseCase(IRequestActivity<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent> request)
        {
            this._request = request;
        }
        public CreateEmployeeResponseEvent Execute(CreateEmployeeRequestEvent request)
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
