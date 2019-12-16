using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Team> Teams => _context.Teams;

        public TeamRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Team> GetAll()
        {
            return Teams.ToList();
        }

        public Team GetById(int id)
        {
            return Teams.First(data => data.Id == id);
        }

        public bool Create(Team data)
        {
            _context.Teams.Add(data);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Team data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Team data)
        {
            throw new NotImplementedException();
        }
    }
}
