﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Common.Enumerations;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<ProjectTask> Tasks => _context.Set<ProjectTask>()
            .Include(x => x.Employee).ThenInclude(x=>x.Account)
            .Include(x => x.Project).ThenInclude(x=>x.Team)
            .Include(x => x.Project).ThenInclude(x=>x.Customer)
            .Include(x => x.Project).ThenInclude(x=>x.Manager)

            .ToList();
        public ProjectTaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ProjectTask> GetTaskListByEmployeeId(int id)
        {
            return Tasks.Where((data) => data.Employee.Id == id);
        }

        public IEnumerable<ProjectTask> GetCountTaskByProjectId(int id)
        {
            return Tasks.Where((data) => data.Project.Id == id);
        }

        public IEnumerable<ProjectTask> GetCountSuccessTaskByProjectId(int id)
        {
            return Tasks.Where((data) => data.Project.Id == id && data.Project.Status == ProjectStatus.Finish);
        }
        
        public IEnumerable<ProjectTask> GetAll()
        {
            return Tasks.ToList();
        }

        public ProjectTask GetById(int id)
        {
            return Tasks.First((data) => data.Id == id);
        }

        public bool Create(ProjectTask data)
        {
            Employee employee = _context.Employees.First(row => row.Id == data.Employee.Id);
            Project project = _context.Projects.First(row => row.Id == data.Project.Id);
            data.Employee = employee;
            data.Project = project;
            _context.Tasks.Add(data);
            _context.SaveChanges();
            return true;
        }

        public bool Update(ProjectTask data)
        {
            ProjectTask Old = Tasks.First(row=>row.Id == data.Id);

            Old.Title = data.Title;
            Old.ActualTile = data.ActualTile;
            Old.Description = data.Description;
            Old.Complexity = data.Complexity;
            Old.Deadline = data.Deadline;
            Old.Employee = _context.Employees.First(row => row.Id == data.Employee.Id);
            Old.Project = _context.Projects.First(row => row.Id == data.Project.Id);
            Old.Status = data.Status;
            _context.SaveChanges();
            return true;
        }

        public bool Delete(ProjectTask data)
        {
            throw new NotImplementedException();
        }
    }
}
