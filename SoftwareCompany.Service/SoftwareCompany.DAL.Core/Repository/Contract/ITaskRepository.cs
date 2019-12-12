using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface ITaskRepository : IRepository
    {
        IEnumerable<Task> Tasks { get; }

        IEnumerable<Task> GetTaskList();
        Task GetTaskById(int id);

        void CreateTask(Task task);
        void UpdateTask(Task task);
        void DeleteTask(Task task);

        IEnumerable<Task> GetTaskListByEmployeeId(int id);
        int GetCountTaskByProjectId(int id);
        int GetCountSuccessTaskByProjectId(int id);
        int GetPercentSuccessTaskByProjectId(int id);
    }
}
