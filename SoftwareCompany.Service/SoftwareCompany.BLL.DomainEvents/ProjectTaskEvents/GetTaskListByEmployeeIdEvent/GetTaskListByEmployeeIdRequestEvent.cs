using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent
{
    public class GetTaskListByEmployeeIdRequestEvent
    {
        public int EmployeeId { get; set; }

        public GetTaskListByEmployeeIdRequestEvent(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
