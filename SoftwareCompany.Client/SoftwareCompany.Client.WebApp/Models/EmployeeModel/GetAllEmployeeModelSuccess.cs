using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.EmployeeModel
{
    public class GetAllEmployeeModelSuccess
    {
        public IEnumerable<Employee> Employees { get; set; }

        public GetAllEmployeeModelSuccess(IEnumerable<Employee> employees)
        {
            this.Employees = employees;
        }
    }
}
