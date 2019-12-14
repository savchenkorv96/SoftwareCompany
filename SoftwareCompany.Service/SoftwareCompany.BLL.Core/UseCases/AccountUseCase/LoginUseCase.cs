﻿using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Validation.Operation.Account.Exceptions;

namespace SoftwareCompany.BLL.Core.UseCases.AccountUseCase
{
    public class LoginUseCase : IUseCase<LoginRequestEvent, LoginResponseEvent>
    {
        private IValidationActivity<LoginRequestEvent> loginValidationActivity;

        private IRequestActivity<LoginRequestEvent, LoginResponseEvent> request;

        public LoginUseCase(IValidationActivity<LoginRequestEvent> loginValidationActivity, IRequestActivity<LoginRequestEvent, LoginResponseEvent> request)
        {
            this.loginValidationActivity = loginValidationActivity;
            this.request = request;
        }

        /// <summary>
        ///  Execute activities needed to log into the system
        /// </summary>
        /// <param name="request">EnterRequestEvent</param>
        /// <returns>User</returns>
        public LoginResponseEvent Execute(LoginRequestEvent request)
        {
            try
            {
                loginValidationActivity.Validate(request);
                return this.request.Execute(request);
            }
            catch (SystemLoginValidationException ex)
            {
                throw new SystemLoginValidationException(ex.Message, ex);
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