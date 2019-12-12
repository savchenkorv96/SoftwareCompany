using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IProjectRepository : IRepository
    {
        IEnumerable<Project> Projects { get; }

        IEnumerable<Project> GetProjectList();
        Project GetProjectById(int id);
        void CreateProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
        IEnumerable<Project> GetProjectListByEmployeeId();
    }
}
