using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<ProjectTask> Tasks => _context.Tasks;

        public ProjectTaskRepository(ApplicationDbContext context)
        {
            _context = context;
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

        public IEnumerable<ProjectTask> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProjectTask GetById(ProjectTask data)
        {
            throw new NotImplementedException();
        }

        public bool Create(ProjectTask data)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProjectTask data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProjectTask data)
        {
            throw new NotImplementedException();
        }
    }
}
