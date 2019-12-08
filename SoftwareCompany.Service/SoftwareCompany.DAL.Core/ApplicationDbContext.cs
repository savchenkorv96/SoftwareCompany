using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> AccountSet { get; set; }
        public DbSet<Employee> EmployeeSet { get; set; }
        public DbSet<Team> TeamSet { get; set; }
        public DbSet<Customer> CustomerSet { get; set; }
        public DbSet<Company> CompanySet { get; set; }
        public DbSet<Project> ProjectSet { get; set; }
        public DbSet<Task> TaskSet { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
