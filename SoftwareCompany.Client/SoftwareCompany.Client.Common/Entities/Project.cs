using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.Client.Common.Enumerations;

namespace SoftwareCompany.Client.Common.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
        public Team Team { get; set; }
        public Employee Manager { get; set; }
        public ProjectType Type { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


    }
}
