using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.DAL.Common.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public Company Company { get; set; }

    }
}
