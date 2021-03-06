﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using SoftwareCompany.DAL.Common.Enumerations;

namespace SoftwareCompany.DAL.Common.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public AccountType Type { get; set; }

    }
}
