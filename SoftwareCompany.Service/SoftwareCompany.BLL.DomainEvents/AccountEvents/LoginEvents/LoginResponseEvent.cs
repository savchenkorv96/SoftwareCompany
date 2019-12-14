using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents
{
    public sealed class LoginResponseEvent
    {
        public Account Account { get; set; }

        public LoginResponseEvent(Account account)
        {
            Account = account;
        }
    }
}
