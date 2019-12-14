using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> Projects { get; }

        IEnumerable<Project> GetProjectListByEmployeeId();
        IEnumerable<Project> GetCountEmployeeByProjectId();
    }
}
