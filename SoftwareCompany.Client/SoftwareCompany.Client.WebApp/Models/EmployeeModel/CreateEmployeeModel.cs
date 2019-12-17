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
        public int AccountId { get; set; }
        public int TeamId { get; set; }
        public List<SelectListItem> Accounts { get; set; }
        public List<SelectListItem> Teams { get; set; }

        public CreateEmployeeModel()
        {
           
        }

        public CreateEmployeeModel( List<SelectListItem> accounts, List<SelectListItem> teams)
        {
            Accounts = accounts;
            Teams = teams;
        }
    }
}
