using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface ITeamRepository : IRepository
    {
        IEnumerable<Team> Teams { get; }

        IEnumerable<Team> GetTeamList();
        Team GetTeamById(int id);
        void CreateTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(Team team);

    }
}
