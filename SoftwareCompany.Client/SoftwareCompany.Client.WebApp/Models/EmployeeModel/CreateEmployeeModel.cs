using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.EmployeeModel
{
    public class CreateEmployeeModel
    {
        public Employee Employee { get; set; }
        public string test1 { get; set; }
        public string test2{ get; set; }
        public IEnumerable<SelectListItem> Accounts { get; set; }
        public IEnumerable<SelectListItem> Teams { get; set; }

        public CreateEmployeeModel()
        {
        }

        public CreateEmployeeModel(Employee employee, IEnumerable<SelectListItem> accounts, IEnumerable<SelectListItem> teams)
        {
            this.Employee = employee;
        }
    }
}
