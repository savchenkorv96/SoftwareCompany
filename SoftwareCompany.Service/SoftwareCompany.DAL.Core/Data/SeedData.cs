using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Common.Enumerations;

namespace SoftwareCompany.DAL.Core.Data
{
    public static class SeedData
    {
        private static ApplicationDbContext Context { get; set; }

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            Context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            Context.Database.Migrate();

            PushData();

        }

        private static void PushData()
        {
            if (!Context.Accounts.Any())
            {
                Context.Accounts.AddRange(
                new Account()
                {
                    Login = "user1", Password = "password1", FirstName = "Roman", LastName = "Savchenko",
                    Phone = "380682269696", Email = "savchenkorv96@gmail.com", Skype = "savchenkorv96",
                    Type = AccountType.Employee
                },
                new Account()
                {
                    Login = "user2", Password = "password2", FirstName = "Alexander", LastName = "Bilakovskyi",
                    Phone = "380676533232", Email = "bilakovskyi@gmail.com", Skype = "bilakovskyi",
                    Type = AccountType.Employee
                },
                new Account()
                {
                    Login = "user3", Password = "password3", FirstName = "Dmitry", LastName = "Perepelica",
                    Phone = "380939304848", Email = "perepelica@gmail.com", Skype = "perepelica",
                    Type = AccountType.Customer
                },
                new Account()
                {
                    Login = "user4", Password = "password4", FirstName = "Vlad", LastName = "Lysenko",
                    Phone = "380688700610", Email = "lysenko@gmail.com", Skype = "lysenko", Type = AccountType.Customer
                }
            );
                Context.SaveChanges();
            }

            if (!Context.Teams.Any())
            {
                Context.Teams.AddRange(
                    new Team()
                    {
                        Name = "ISTKM",
                        Description = "Clean Arch"
                    }); Context.SaveChanges();
            }

            if (!Context.Employees.Any())
            {
                Context.Employees.AddRange(
                    new Employee()
                    {
                        Account = Context.Accounts.First(row => row.Login == "user1"),
                        DateOfEmployment = DateTime.UtcNow,
                        Team = Context.Teams.First(row => row.Name == "ISTKM"),
                        Position = "Developer",
                        Salary = 600
                    },
                    new Employee()
                    {
                        Account = Context.Accounts.First(row => row.Login == "user2"),
                        DateOfEmployment = DateTime.UtcNow,
                        Team = Context.Teams.First(row => row.Name == "ISTKM"),
                        Position = "Developer",
                        Salary = 600
                    }); Context.SaveChanges();
            }

            if (!Context.Companies.Any())
            {
                Context.Companies.AddRange(
                    new Company() { Name = "Lysenko LTD", Description = "Games" },
                    new Company() { Name = "Perepelica LTD", Description = "Post system" }
                ); Context.SaveChanges();
            }

            if (!Context.Customers.Any())
            {
                Context.Customers.AddRange(
                    new Customer()
                    {
                        Account = Context.Accounts.First(row => row.Login == "user3"),
                        Company = Context.Companies.First(row => row.Name == "Perepelica LTD")
                    },
                    new Customer()
                    {
                        Account = Context.Accounts.First(row => row.Login == "user4"),
                        Company = Context.Companies.First(row => row.Name == "Lysenko LTD")
                    }
                ); Context.SaveChanges();
            }

            if (!Context.Projects.Any())
            {
                Context.Projects.AddRange(
                    new Project()
                    {
                        Title = "SoftwareCompany",
                        Description = "Course work",
                        Customer = Context.Customers.First(row => row.Company.Name == "Lysenko LTD"),
                        Manager = Context.Employees.First(row => row.Account.Login == "user1"),
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(24),
                        Type = ProjectType.Web,
                        Status = ProjectStatus.New,
                        Team = Context.Teams.First(row => row.Name == "ISTKM")
                    }
                ); Context.SaveChanges();
            }

            if (!Context.Tasks.Any())
            {
                Context.Tasks.AddRange(

                    new ProjectTask()
                    {
                        Employee = Context.Employees.First(row => row.Account.Login == "user2"),
                        Complexity = 24,
                        Deadline = DateTime.Now.AddDays(5),
                        Title = "Create Repository",
                        Description = "Create repository for Employee Table",
                        Project = Context.Projects.First(row => row.Title == "SoftwareCompany"),
                        Status = TaskStatus.Open,
                        ActualTile = DateTime.Now
                    }

                ); Context.SaveChanges();
            }

        }
            
            
    }
}
