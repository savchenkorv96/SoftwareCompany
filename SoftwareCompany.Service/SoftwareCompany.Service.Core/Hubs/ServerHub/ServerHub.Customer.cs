using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetAllCustomerEvent;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;
using SoftwareCompany.Service.Core.Helpers;

namespace SoftwareCompany.Service.Core.Hubs.ServerHub
{
    partial class ServerHub
    {
        public async Task<OperationStatusInfo> GetAllCustomer()
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAllCustomerRequestEvent request = new GetAllCustomerRequestEvent();

                try
                {
                    GetAllCustomerResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAllCustomerRequestEvent, GetAllCustomerResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Customers;

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

        public async Task<OperationStatusInfo> GetCustomerById(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetCustomerByIdRequestEvent request = new GetCustomerByIdRequestEvent(id);

                try
                {
                    GetCustomerByIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetCustomerByIdRequestEvent, GetCustomerByIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Customer;

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
