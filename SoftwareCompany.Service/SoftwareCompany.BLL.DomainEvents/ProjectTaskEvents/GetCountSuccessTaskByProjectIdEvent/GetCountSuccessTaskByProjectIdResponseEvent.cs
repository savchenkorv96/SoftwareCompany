using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent
{
    public class GetCountSuccessTaskByProjectIdResponseEvent
    {
        public int CountSuccessTask { get; set; }

        public GetCountSuccessTaskByProjectIdResponseEvent(int countSuccessTask)
        {
            CountSuccessTask = countSuccessTask;
        }
    }
}
