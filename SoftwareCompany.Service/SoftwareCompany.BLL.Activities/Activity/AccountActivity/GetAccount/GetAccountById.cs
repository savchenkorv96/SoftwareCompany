using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.GetAccount
{
    public class GetAccountById : IRequestActivity<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent>
    {
        private readonly IAccountRepository _accountRepository;
        public GetAccountById(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }

        public GetAccountByIdResponseEvent Execute(GetAccountByIdRequestEvent request)
        {
            GetAccountByIdResponseEvent response;

            try
            {
                Account account = _accountRepository.GetById(request.Id);
                response = new GetAccountByIdResponseEvent(account);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Id is incorrect!", ex);
            }

            return response;
        }
    }
}
