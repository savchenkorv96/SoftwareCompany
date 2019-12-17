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
                .Include(x => x.Customer).ThenInclude(x=>x.Company)
                .Include(x => x.Customer).ThenInclude(x=>x.Account)
                .Include(x => x.Manager).ThenInclude(x=>x.Account)
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
            Employee employee = _context.Employees.First(row => row.Id == data.Manager.Id);
            Customer customer = _context.Customers.First(row => row.Id == data.Customer.Id);
            Team team = _context.Teams.First(row => row.Id == data.Team.Id);
            data.Manager = employee;
            data.Customer = customer;
            data.Team = team;
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
