using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent
{
    public class GetCountTaskByProjectIdResponseEvent
    {
        public int CountTask { get; set; }

        public GetCountTaskByProjectIdResponseEvent(int countTask)
        {
            CountTask = countTask;
        }
    }
}
