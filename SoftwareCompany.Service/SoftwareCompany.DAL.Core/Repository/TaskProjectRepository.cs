using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class TaskProjectRepository : ITaskProjectRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<ProjectTask> Tasks => _context.Tasks;

        public TaskProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProjectTask> GetTaskList()
        {
            throw new NotImplementedException();
        }

        public ProjectTask GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateTask(ProjectTask task)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(ProjectTask task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(ProjectTask task)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectTask> GetTaskListByEmployeeId(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCountTaskByProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCountSuccessTaskByProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public int GetPercentSuccessTaskByProjectId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
