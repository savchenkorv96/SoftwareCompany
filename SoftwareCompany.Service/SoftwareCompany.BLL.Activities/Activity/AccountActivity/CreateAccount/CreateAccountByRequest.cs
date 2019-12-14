using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.DAL.Common.Entities;
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
            CreateAccountResponseEvent response;

            try
            {
                bool status = _accountRepository.Create(request.Account);
                response = new CreateAccountResponseEvent(status);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Unable to create account", ex);
            }

            return response;
        }
    }
}
