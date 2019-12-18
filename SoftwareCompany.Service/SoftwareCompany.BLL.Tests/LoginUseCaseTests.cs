using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using SoftwareCompany.BLL.Activities.Activity.AccountActivity.Login;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.Core.UseCases.AccountUseCase;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Exceptions;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Common.Enumerations;
using SoftwareCompany.DAL.Core.Repository;
using Xunit;

namespace SoftwareCompany.BLL.Tests
{
    public class LoginUseCaseTests
    {
        private Mock<AccountRepository> mock;

        private IUseCase<LoginRequestEvent, LoginResponseEvent> SetupMock()
        {
            mock = new Mock<AccountRepository>(null);

            mock.Setup(x => x.Accounts).Returns(new Account[]
            {
                new Account{Id = 1,
                    Login = "login1",
                    Password = "password1",
                    FirstName = "FirstName1",
                    LastName = "LastName1",
                    Email = "login1@gmail.com",
                    Phone = "380694512356",
                    Skype = "login1",
                    Type = AccountType.Employee},
                new Account{Id = 2,
                    Login = "login2",
                    Password = "password2",
                    FirstName = "FirstName2",
                    LastName = "LastName2",
                    Email = "login2@gmail.com",
                    Phone = "380694512352",
                    Skype = "login2",
                    Type = AccountType.Employee},
                new Account{Id = 3,
                    Login = "login3",
                    Password = "password3",
                    FirstName = "FirstName3",
                    LastName = "LastName3",
                    Email = "login3@gmail.com",
                    Phone = "380694512353",
                    Skype = "login3",
                    Type = AccountType.Employee}
            });

            IValidationActivity<LoginRequestEvent> validationActivity = new LoginValidationActivity(new LoginOperationValidationRule());
            IRequestActivity<LoginRequestEvent, LoginResponseEvent> request = new GetAccountByRequest(mock.Object);

            IUseCase<LoginRequestEvent, LoginResponseEvent> loginUseCase = new LoginUseCase(validationActivity,request);

            return loginUseCase;
        }

        [Theory]
        [InlineData("login1", "password1")]
        [InlineData("login2", "password2")]
        [InlineData("login3", "password3")]
        public void LoginUseCaseTestWithCorrectData(string login, string password)
        {
            var loginUseCase = SetupMock();

            LoginResponseEvent response = null;

            try
            {
                response = loginUseCase.Execute(new LoginRequestEvent(login, password));
            }
            catch (Exception ex)
            {
            }

            Assert.Equal(mock.Object.Accounts.First(data=>data.Login == login && data.Password == password),response.Account);
        }

        [Theory]
        [InlineData("login", "pass")]
        [InlineData("login", "password2")]
        [InlineData("login3", "password")]
        public void LoginUseCaseTestWithInCorrectData(string login, string password)
        {
            var loginUseCase = SetupMock();
            
            Assert.Throws<MissingMemberException>(()=>loginUseCase.Execute(new LoginRequestEvent(login,password)));
        }


        [Theory]
        [InlineData("", "")]
        [InlineData("login", "")]
        [InlineData("", "password")]
        public void LoginUseCaseTestWithInvalidData(string login, string password)
        {
            var loginUseCase = SetupMock();

            Assert.Throws<SystemLoginValidationException>(() => loginUseCase.Execute(new LoginRequestEvent(login, password)));
        }
    }
}
