using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.Service.Core.Helpers;
using Task = System.Threading.Tasks.Task;

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
    }
}
