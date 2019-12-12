using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Task> Tasks => _context.Tasks;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetTaskList()
        {
            throw new NotImplementedException();
        }

        public Task GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(Task task)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetTaskListByEmployeeId(int id)
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
