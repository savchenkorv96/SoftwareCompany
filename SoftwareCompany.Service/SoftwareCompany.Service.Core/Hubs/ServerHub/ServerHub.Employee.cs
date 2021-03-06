﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetCountEmployeeByTeamIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.Service.Core.Helpers;

namespace SoftwareCompany.Service.Core.Hubs.ServerHub
{
    partial class ServerHub
    {
        public async Task<OperationStatusInfo> GetEmployeeById(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetEmployeeByIdRequestEvent request = new GetEmployeeByIdRequestEvent(id);

                try
                {
                    GetEmployeeByIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Employee;

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

        public async Task<OperationStatusInfo> GetCountEmployeeByTeamId(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetCountEmployeeByTeamIdRequestEvent request = new GetCountEmployeeByTeamIdRequestEvent(id);

                try
                {
                    GetCountEmployeeByTeamIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetCountEmployeeByTeamIdRequestEvent, GetCountEmployeeByTeamIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.CountEmployee;

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

        public async Task<OperationStatusInfo> GetEmployeeByAccountId(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetEmployeeByAccountIdRequestEvent request = new GetEmployeeByAccountIdRequestEvent(id);

                try
                {
                    GetEmployeeByAccountIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Employee;

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

        public async Task<OperationStatusInfo> GetAllEmployee()
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAllEmployeeRequestEvent request = new GetAllEmployeeRequestEvent();

                try
                {
                    GetAllEmployeeResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Employees;

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

        public async Task<OperationStatusInfo> CreateEmployee(Employee employee)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                CreateEmployeeRequestEvent request = new CreateEmployeeRequestEvent(employee);

                try
                {
                    CreateEmployeeResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent>>().Execute(request);

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
    }
}
