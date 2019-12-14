using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.CreateAccount
{
    class CreateAccountByRequest : IRequestActivity<CreateAccountRequestEvent, CreateAccountResponseEvent>
    {
        private readonly IAccountRepository _accountRepository;
        public CreateAccountByRequest(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }

        public CreateAccountResponseEvent Execute(CreateAccountRequestEvent request)
        {
            throw new NotImplementedException();
        }
    }
}
