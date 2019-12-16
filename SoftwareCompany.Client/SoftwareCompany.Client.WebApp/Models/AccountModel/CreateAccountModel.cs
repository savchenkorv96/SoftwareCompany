using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;
using SoftwareCompany.Client.Common.Enumerations;

namespace SoftwareCompany.Client.WebApp.Models.AccountModel
{
    public class CreateAccountModel
    {
        public Account Account { get; set; }
        public CreateAccountModel()
        {
        }

        public CreateAccountModel(Account account)
        {
            Account = account;
        }
    }
}
