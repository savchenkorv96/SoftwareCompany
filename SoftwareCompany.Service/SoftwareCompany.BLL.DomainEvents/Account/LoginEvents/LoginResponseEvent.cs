
namespace SoftwareCompany.BLL.DomainEvents.Account.LoginEvents
{
    using DAL.Common.Entities;
    public sealed class LoginResponseEvent
    {
        public Account Account { get; set; }

        public LoginResponseEvent(Account account)
        {
            Account = account;
        }
    }
}
