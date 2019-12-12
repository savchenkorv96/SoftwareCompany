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

        public IEnumerable<Team> GetTeamList()
        {
            throw new NotImplementedException();
        }

        public Team GetTeamById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
