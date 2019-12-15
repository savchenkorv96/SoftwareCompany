using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Activity.TeamActivity.CreateTeam;
using SoftwareCompany.BLL.Activities.Activity.TeamActivity.GetAllTeam;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.Core.UseCases.AccountUseCase;
using SoftwareCompany.BLL.Core.UseCases.EmployeeUseCase;
using SoftwareCompany.BLL.Core.UseCases.TeamUseCase;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAllAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;

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

            this.collection.Add(typeof(IUseCase<GetAllAccountRequestEvent, GetAllAccountResponseEvent>),
                new GetAllAccountUseCase(activitiesFactory.Create<IRequestActivity<GetAllAccountRequestEvent, GetAllAccountResponseEvent>>()));


            this.collection.Add(typeof(IUseCase<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent>),
                new CreateEmployeeUseCase(activitiesFactory.Create<IRequestActivity<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent>>()));
            this.collection.Add(typeof(IUseCase<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent>),
                new GetAllEmployeeUseCase(activitiesFactory.Create<IRequestActivity<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent>>()));
            this.collection.Add(typeof(IUseCase<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent>),
                new GetEmployeeByIdUseCase(activitiesFactory.Create<IRequestActivity<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent>>()));
            this.collection.Add(typeof(IUseCase<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent>),
                new GetEmployeeByAccountIdUseCase(activitiesFactory.Create<IRequestActivity<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent>>()));


            this.collection.Add(typeof(IUseCase<CreateTeamRequestEvent, CreateTeamResponseEvent>),
                new CreateTeamUseCase(activitiesFactory.Create<IRequestActivity<CreateTeamRequestEvent, CreateTeamResponseEvent>>()));
            this.collection.Add(typeof(IUseCase<GetAllTeamRequestEvent, GetAllTeamResponseEvent>),
                new GetAllTeamUseCase(activitiesFactory.Create<IRequestActivity<GetAllTeamRequestEvent, GetAllTeamResponseEvent>>()));
            this.collection.Add(typeof(IUseCase<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent>),
                new GetTeamByIdUseCase(activitiesFactory.Create<IRequestActivity<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent>>()));


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
