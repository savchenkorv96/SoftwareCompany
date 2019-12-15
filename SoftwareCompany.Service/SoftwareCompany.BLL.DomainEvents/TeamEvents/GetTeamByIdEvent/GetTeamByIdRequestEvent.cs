using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent
{
    public class GetTeamByIdRequestEvent
    {
        public int Id { get; set; }

        public GetTeamByIdRequestEvent(int id)
        {
            Id = id;
        }
    }
}
