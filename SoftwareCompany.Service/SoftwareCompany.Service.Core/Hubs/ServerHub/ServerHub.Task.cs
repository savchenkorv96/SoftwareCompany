using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.Service.Core.Helpers;

namespace SoftwareCompany.Service.Core.Hubs.ServerHub
{
    partial class ServerHub
    {
        public async Task<OperationStatusInfo> CreateProjectTask(ProjectTask projectTask)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                CreateProjectTaskRequestEvent request = new CreateProjectTaskRequestEvent(projectTask);

                try
                {
                    CreateProjectTaskResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<CreateProjectTaskRequestEvent, CreateProjectTaskResponseEvent>>().Execute(request);

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

        public async Task<OperationStatusInfo> UpdateProjectTask(ProjectTask projectTask)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                UpdateProjectTaskRequestEvent request = new UpdateProjectTaskRequestEvent(projectTask);

                try
                {
                   UpdateProjectTaskResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<UpdateProjectTaskRequestEvent, UpdateProjectTaskResponseEvent>>().Execute(request);

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

        public async Task<OperationStatusInfo> GetAllProjectTask()
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetAllProjectTaskRequestEvent request = new GetAllProjectTaskRequestEvent();

                try
                {
                    GetAllProjectTaskResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetAllProjectTaskRequestEvent, GetAllProjectTaskResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.ProjectTasks;

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

        public async Task<OperationStatusInfo> GetProjectTaskById(int id)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetProjectTaskByIdRequestEvent request = new GetProjectTaskByIdRequestEvent(id);

                try
                {
                    GetProjectTaskByIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetProjectTaskByIdRequestEvent, GetProjectTaskByIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.ProjectTask;

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

        public async Task<OperationStatusInfo> GetProjectTaskByEmployeeId(int employeeId)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetTaskListByEmployeeIdRequestEvent request = new GetTaskListByEmployeeIdRequestEvent(employeeId);

                try
                {
                    GetTaskListByEmployeeIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetTaskListByEmployeeIdRequestEvent, GetTaskListByEmployeeIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.ProjectTasks;

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

        public async Task<OperationStatusInfo> GetCountProjectTaskByProjectId(int projectId)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetCountTaskByProjectIdRequestEvent request = new GetCountTaskByProjectIdRequestEvent(projectId);

                try
                {
                    GetCountTaskByProjectIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetCountTaskByProjectIdRequestEvent, GetCountTaskByProjectIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.CountTask;

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

        public async Task<OperationStatusInfo> GetCountSuccessProjectTaskByProjectId(int projectId)
        {
            return await Task.Run(() =>
            {
                OperationStatusInfo operationStatusInfo = new OperationStatusInfo(operationStatus: OperationStatus.Done);
                GetCountSuccessTaskByProjectIdRequestEvent request = new GetCountSuccessTaskByProjectIdRequestEvent(projectId);

                try
                {
                    GetCountSuccessTaskByProjectIdResponseEvent response =
                        _hubEnvironment.UseCaseFactory.Create<IUseCase<GetCountSuccessTaskByProjectIdRequestEvent, GetCountSuccessTaskByProjectIdResponseEvent>>().Execute(request);

                    operationStatusInfo.AttachedObject = response.CountSuccessTask;

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
