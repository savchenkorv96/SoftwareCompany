using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAllAccountEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.GetAllAccount
{
    class GetAllAccountByRequest : IRequestActivity<GetAllAccountRequestEvent, GetAllAccountResponseEvent>
    {
        private readonly IAccountRepository _accountRepository;
        public GetAllAccountByRequest(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }

        public GetAllAccountResponseEvent Execute(GetAllAccountRequestEvent request)
        {
            GetAllAccountResponseEvent response;

            try
            {
                IEnumerable<Account> accountList = _accountRepository.GetAll();
                response = new GetAllAccountResponseEvent(accountList);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("request is incorrect!", ex);
            }

            return response;
        }
    }
}
