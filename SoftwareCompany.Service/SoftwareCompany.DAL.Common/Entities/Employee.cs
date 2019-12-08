using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.DAL.Common.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfEmployment { get; set; }

    }
}
