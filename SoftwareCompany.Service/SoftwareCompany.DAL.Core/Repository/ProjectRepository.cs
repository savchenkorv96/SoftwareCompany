using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Project> Projects => _context.Projects;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Project> GetProjectListByEmployeeId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetCountEmployeeByProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Project data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Project data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Project data)
        {
            throw new NotImplementedException();
        }
    }
}
