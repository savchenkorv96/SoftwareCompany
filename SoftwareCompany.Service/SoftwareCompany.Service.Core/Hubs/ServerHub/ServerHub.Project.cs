using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.Service.Core.Helpers;

namespace SoftwareCompany.Service.Core.Hubs.ServerHub
{
    partial class ServerHub
    {
        public async Task<OperationStatusInfo> CreateProject(Project project)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                CreateProjectRequestEvent request = new CreateProjectRequestEvent(project);

                try
                {
                    CreateProjectResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<CreateProjectRequestEvent, CreateProjectResponseEvent>>().Execute(request);

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

        public async Task<OperationStatusInfo> UpdateProject(Project project)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                UpdateProjectRequestEvent request = new UpdateProjectRequestEvent(project);

                try
                {
                    UpdateProjectResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<UpdateProjectRequestEvent, UpdateProjectResponseEvent>>().Execute(request);

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

        public async Task<OperationStatusInfo> GetAllProject()
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAllProjectRequestEvent request = new GetAllProjectRequestEvent();

                try
                {
                    GetAllProjectResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAllProjectRequestEvent, GetAllProjectResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Projects;

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

        public async Task<OperationStatusInfo> GetProjectById(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetProjectByIdRequestEvent request = new GetProjectByIdRequestEvent(id);

                try
                {
                    GetProjectByIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetProjectByIdRequestEvent, GetProjectByIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Project;

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

        public async Task<OperationStatusInfo> GetProjectByTeamId(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetProjectByTeamIdRequestEvent request = new GetProjectByTeamIdRequestEvent(id);

                try
                {
                    GetProjectByTeamIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetProjectByTeamIdRequestEvent, GetProjectByTeamIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.Projects;

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
