using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IProjectTaskRepository : IRepository<ProjectTask>
    {
        IEnumerable<ProjectTask> Tasks { get; }
        
        IEnumerable<ProjectTask> GetTaskListByEmployeeId(int id);
        int GetCountTaskByProjectId(int id);
        int GetCountSuccessTaskByProjectId(int id);
    }
}
