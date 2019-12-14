using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents
{
    public sealed class LoginRequestEvent
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public LoginRequestEvent(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
