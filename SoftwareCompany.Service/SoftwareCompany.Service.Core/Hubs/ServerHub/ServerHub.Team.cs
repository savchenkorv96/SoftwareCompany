using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.Service.Core.Helpers;

namespace SoftwareCompany.Service.Core.Hubs.ServerHub
{
    partial class ServerHub
    {
        public async Task<OperationStatusInfo> GetTeamById(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetTeamByIdRequestEvent request = new GetTeamByIdRequestEvent(id);

                try
                {
                    GetTeamByIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Team;

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
        public async Task<OperationStatusInfo> GetAllTeam()
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAllTeamRequestEvent request = new GetAllTeamRequestEvent();

                try
                {
                    GetAllTeamResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAllTeamRequestEvent, GetAllTeamResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Teams;

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
        public async Task<OperationStatusInfo> CreateTeam(Team team)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                CreateTeamRequestEvent request = new CreateTeamRequestEvent(team);

                try
                {
                    CreateTeamResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<CreateTeamRequestEvent, CreateTeamResponseEvent>>().Execute(request);

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
