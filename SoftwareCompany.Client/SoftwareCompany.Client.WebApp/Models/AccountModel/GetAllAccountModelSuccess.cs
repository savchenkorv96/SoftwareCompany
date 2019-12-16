using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareCompany.Client.Common.Entities;

namespace SoftwareCompany.Client.WebApp.Models.AccountModel
{
    public class GetAllAccountModelSuccess
    {
        public List<Account> List { get; set; }

        public GetAllAccountModelSuccess(List<Account> list)
        {
            List = list;
        }
    }
}
