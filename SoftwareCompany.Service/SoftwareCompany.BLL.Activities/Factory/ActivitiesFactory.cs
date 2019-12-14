﻿using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Activity.AccountActivity.Login;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.Rules.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operation.Account.Contract;
using SoftwareCompany.DAL.Core.Factory.Contract;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.BLL.Activities.Factory
{
    public class ActivitiesFactory : IActivitiesFactory
    {
        readonly Dictionary<Type, object> ruleCollection = new Dictionary<Type, object>();

        public ActivitiesFactory(IRepositoryFactory repositoryFactory, IValidationRuleFactory validationRuleFactory)
        {
            // Extension point of the factory
            this.ruleCollection.Add(typeof(IValidationActivity<LoginRequestEvent>), new LoginValidationActivity(validationRuleFactory.Create<ILoginOperationValidationRule>()));
            this.ruleCollection.Add(typeof(IRequestActivity<LoginRequestEvent,LoginResponseEvent>), new GetUserByRequest(repositoryFactory.Create<IAccountRepository>()));

        }

        public T Create<T>()
        {
            Type type = typeof(T);

            if (!this.ruleCollection.ContainsKey(type))
            {
                throw new MissingMemberException(type.ToString() + "is missing in the rule collection");
            }

            return (T)this.ruleCollection[type];
        }
    }
}