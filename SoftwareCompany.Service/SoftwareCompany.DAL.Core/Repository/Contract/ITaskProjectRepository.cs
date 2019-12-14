using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface ITaskProjectRepository : IRepository
    {
        IEnumerable<ProjectTask> Tasks { get; }

        IEnumerable<ProjectTask> GetTaskList();
        ProjectTask GetTaskById(int id);

        void CreateTask(ProjectTask task);
        void UpdateTask(ProjectTask task);
        void DeleteTask(ProjectTask task);

        IEnumerable<ProjectTask> GetTaskListByEmployeeId(int id);
        int GetCountTaskByProjectId(int id);
        int GetCountSuccessTaskByProjectId(int id);
        int GetPercentSuccessTaskByProjectId(int id);
    }
}
