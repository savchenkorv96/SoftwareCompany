using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SoftwareCompany.Client.WebApp.Models.TaskModel
{
    public class GetProjectTaskByEmployeeIdModel
    {
        public List<SelectListItem> Employee { get; set; }
        public int EmployeeId { get; set; }

        public GetProjectTaskByEmployeeIdModel(List<SelectListItem> employee)
        {
            Employee = employee;
        }

        public GetProjectTaskByEmployeeIdModel()
        {
        }
    }
}
