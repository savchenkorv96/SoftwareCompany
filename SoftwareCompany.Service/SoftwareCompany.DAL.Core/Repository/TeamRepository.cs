using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Team GetById(Team data)
        {
            throw new NotImplementedException();
        }

        public Team Create(Team data)
        {
            throw new NotImplementedException();
        }

        public Team Update(Team data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Team data)
        {
            throw new NotImplementedException();
        }
    }
}
