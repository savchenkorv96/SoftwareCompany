using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.Activities.Factory;
using SoftwareCompany.BLL.Core.Contract;
using SoftwareCompany.BLL.Core.Factory;
using SoftwareCompany.BLL.Rules.Contract;
using SoftwareCompany.BLL.Rules.Factory;
using SoftwareCompany.DAL.Core;
using SoftwareCompany.DAL.Core.Factory;
using SoftwareCompany.DAL.Core.Factory.Contract;

namespace SoftwareCompany.Service.Core.Environment
{
    public class HubEnvironment
    {
        public IUseCaseFactory UseCaseFactory { get; set; }

        public HubEnvironment(ApplicationDbContext context)
        {
            IValidationRuleFactory validationRuleFactory = new ValidationRuleFactory();
            IRepositoryFactory repositoryFactory = new RepositoryFactory(context);
            IActivitiesFactory activitiesFactory = new ActivitiesFactory(repositoryFactory, validationRuleFactory);

            UseCaseFactory = new UseCaseFactory(activitiesFactory);
        }
    }
}
