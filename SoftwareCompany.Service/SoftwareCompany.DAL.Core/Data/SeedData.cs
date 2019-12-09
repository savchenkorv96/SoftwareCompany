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
        private static ApplicationDbContext context { get; set; }

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            PushData();


            foreach (var itemAccount in context.Accounts.ToList())
            {
                Console.WriteLine(itemAccount.Login + " | " + itemAccount.Password);
            }

        }

        private static void PushData()
        {
            if (!context.Accounts.Any())
            {
                context.Accounts.AddRange(
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
                context.SaveChanges();
            }

            if (!context.Teams.Any())
            {
                context.Teams.AddRange(
                    new Team()
                    {
                        Name = "ISTKM",
                        Description = "Clean Arch"
                    }); context.SaveChanges();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee()
                    {
                        Account = context.Accounts.First(row => row.Login == "user1"),
                        DateOfEmployment = DateTime.UtcNow,
                        Team = context.Teams.First(row => row.Name == "ISTKM"),
                        Position = "Developer",
                        Salary = 600
                    },
                    new Employee()
                    {
                        Account = context.Accounts.First(row => row.Login == "user2"),
                        DateOfEmployment = DateTime.UtcNow,
                        Team = context.Teams.First(row => row.Name == "ISTKM"),
                        Position = "Developer",
                        Salary = 600
                    }); context.SaveChanges();
            }

            if (!context.Companies.Any())
            {
                context.Companies.AddRange(
                    new Company() { Name = "Lysenko LTD", Description = "Games" },
                    new Company() { Name = "Perepelica LTD", Description = "Post system" }
                ); context.SaveChanges();
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer()
                    {
                        Account = context.Accounts.First(row => row.Login == "user3"),
                        Company = context.Companies.First(row => row.Name == "Perepelica LTD")
                    },
                    new Customer()
                    {
                        Account = context.Accounts.First(row => row.Login == "user4"),
                        Company = context.Companies.First(row => row.Name == "Lysenko LTD")
                    }
                ); context.SaveChanges();
            }

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project()
                    {
                        Title = "SoftwareCompany",
                        Description = "Course work",
                        Customer = context.Customers.First(row => row.Company.Name == "Lysenko LTD"),
                        Manager = context.Employees.First(row => row.Account.Login == "user1"),
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(24),
                        Type = ProjectType.Web,
                        Status = ProjectStatus.New,
                        Team = context.Teams.First(row => row.Name == "ISTKM")
                    }
                ); context.SaveChanges();
            }

            if (!context.Tasks.Any())
            {
                context.Tasks.AddRange(

                    new Task()
                    {
                        Employee = context.Employees.First(row => row.Account.Login == "user2"),
                        Complexity = 24,
                        Deadline = DateTime.Now.AddDays(5),
                        Title = "Create Repository",
                        Description = "Create repository for Employee Table",
                        Project = context.Projects.First(row => row.Title == "SoftwareCompany"),
                        Status = TaskStatus.Open
                    }

                ); context.SaveChanges();
            }

        }
            
            
    }
}
