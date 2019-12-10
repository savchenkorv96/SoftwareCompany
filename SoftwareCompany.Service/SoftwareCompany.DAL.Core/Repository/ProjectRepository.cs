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

    }
}
