using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.DAL.Core.Repository.Contract;
using SoftwareCompany.DAL.Common;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.Activities.Activity.AccountActivity.Login
{
    class GetUserByRequest : IRequestActivity<LoginRequestEvent, LoginResponseEvent>
    {
        private IAccountRepository accountRepository;
        public GetUserByRequest(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public LoginResponseEvent Execute(LoginRequestEvent request)
        {
            LoginResponseEvent response = null;

            try
            {
                Account account = accountRepository.GetAccountByLoginAndPassword(request.Login, request.Password);
                response = new LoginResponseEvent(account);
            }
            catch (Exception ex)
            {
                throw new MissingMemberException("Login or password is incorrect!", ex);
            }

            return response;
        }
    }
}
