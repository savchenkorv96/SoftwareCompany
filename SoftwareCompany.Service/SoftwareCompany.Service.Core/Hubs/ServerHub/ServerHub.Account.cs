﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAllAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.Service.Core.Helpers;

namespace SoftwareCompany.Service.Core.Hubs.ServerHub
{
    partial class ServerHub
    {
        public async Task<OperationStatusInfo> Login(string login, string password)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                LoginRequestEvent request = new LoginRequestEvent(login, password);

                try
                {
                    LoginResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<LoginRequestEvent, LoginResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Account;

                    return operationStatusInfo;
                }
                catch (Exception ex)
                {
                    operationStatusInfo.OperationStatus = OperationStatus.Cancelled;
                    operationStatusInfo.AttachedInfo = ex.Message;
                }

                return operationStatusInfo;
            });
        }

        public async Task<OperationStatusInfo> CreateAccount(Account account)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                CreateAccountRequestEvent request = new CreateAccountRequestEvent(account);

                try
                {
                    CreateAccountResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<CreateAccountRequestEvent, CreateAccountResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Status;

                    return operationStatusInfo;
                }
                catch (Exception ex)
                {
                    operationStatusInfo.OperationStatus = OperationStatus.Cancelled;
                    operationStatusInfo.AttachedInfo = ex.Message;
                }

                return operationStatusInfo;
            });
        }

        public async Task<OperationStatusInfo> GetAccountById(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAccountByIdRequestEvent request = new GetAccountByIdRequestEvent(id);

                try
                {
                    GetAccountByIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Account;

                    return operationStatusInfo;
                }
                catch (Exception ex)
                {
                    operationStatusInfo.OperationStatus = OperationStatus.Cancelled;
                    operationStatusInfo.AttachedInfo = ex.Message;
                }

                return operationStatusInfo;
            });
        }

        public async Task<OperationStatusInfo> GetAllAccount()
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAllAccountRequestEvent request = new GetAllAccountRequestEvent();

                try
                {
                    GetAllAccountResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAllAccountRequestEvent, GetAllAccountResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.ListAccounts;

                    return operationStatusInfo;
                }
                catch (Exception ex)
                {
                    operationStatusInfo.OperationStatus = OperationStatus.Cancelled;
                    operationStatusInfo.AttachedInfo = ex.Message;
                }

                return operationStatusInfo;
            });
        }
    }
}
