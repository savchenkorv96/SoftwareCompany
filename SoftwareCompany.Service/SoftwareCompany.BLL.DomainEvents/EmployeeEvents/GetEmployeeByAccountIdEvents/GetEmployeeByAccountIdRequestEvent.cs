using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents
{
    public class GetEmployeeByAccountIdRequestEvent
    {
        public int AccountId { get; set; }

        public GetEmployeeByAccountIdRequestEvent(int accountId)
        {
            AccountId = accountId;
        }
    }
}
