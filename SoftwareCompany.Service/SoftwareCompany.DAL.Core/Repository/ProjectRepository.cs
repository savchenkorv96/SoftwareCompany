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

        public IEnumerable<Project> GetProjectList()
        {
            throw new NotImplementedException();
        }

        public Project GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(Project project)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetProjectListByEmployeeId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetCountEmployeeByProjectId()
        {
            throw new NotImplementedException();
        }
    }
}
