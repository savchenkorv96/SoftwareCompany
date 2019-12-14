using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Enumerations;

namespace SoftwareCompany.DAL.Common.Entities
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Project Project { get; set; }
        public Employee Employee { get; set; }
        public DateTime Deadline { get; set; }
        public double Complexity { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime ActualTile { get; set; }
    }
}
