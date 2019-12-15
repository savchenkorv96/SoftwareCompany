using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.Core.UseCases.AccountUseCase;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;

namespace SoftwareCompany.BLL.Core.Factory
{
    public class UseCaseFactory : IUseCaseFactory
    {
        readonly Dictionary<Type, object> collection = new Dictionary<Type, object>();

        public UseCaseFactory(IActivitiesFactory activitiesFactory)
        {
            // Extension point of the factory
            this.collection.Add(typeof(IUseCase<LoginRequestEvent, LoginResponseEvent>),
                new LoginUseCase(activitiesFactory.Create<IValidationActivity<LoginRequestEvent>>(),
                    activitiesFactory.Create<IRequestActivity<LoginRequestEvent, LoginResponseEvent>>()));

            this.collection.Add(typeof(IUseCase<CreateAccountRequestEvent, CreateAccountResponseEvent>),
                new CreateAccountUseCase(activitiesFactory.Create<IValidationActivity<CreateAccountRequestEvent>>(),
                    activitiesFactory.Create<IRequestActivity<CreateAccountRequestEvent, CreateAccountResponseEvent>>()));


            this.collection.Add(typeof(IUseCase<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent>),
                new GetAccountByIdUseCase(activitiesFactory.Create<IRequestActivity<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent>>()));

        }

        public T Create<T>()
        {
            Type type = typeof(T);

            if (!this.collection.ContainsKey(type))
            {
                throw new MissingMemberException(type.ToString() + "is missing in the collection");
            }

            return (T)this.collection[type];
        }
    }
}
