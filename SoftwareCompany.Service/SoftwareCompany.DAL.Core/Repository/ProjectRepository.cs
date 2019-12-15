using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<Project> Projects =>
            _context.Set<Project>().Include(x => x.Team)
                .Include(x => x.Customer)
                .Include(x => x.Manager)
                .ToList();

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Project> GetProjectListByTeamId(int id)
        {
            return Projects.Where(data => data.Team.Id == id);
        }


        public IEnumerable<Project> GetAll()
        {
            return Projects.ToList();
        }

        public Project GetById(int id)
        {
            return Projects.First((data) => data.Id == id);
        }

        public bool Create(Project data)
        {
            _context.Projects.Add(data);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Project data)
        {
            Project oldProject = Projects.First((row) => row.Id == data.Id);
            oldProject = data;
            return true;

        }

        public bool Delete(Project data)
        {
            throw new NotImplementedException();
        }
    }
}
