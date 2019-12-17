using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Activities.Activity.AccountActivity.CreateAccount;
using SoftwareCompany.BLL.Activities.Activity.AccountActivity.GetAccount;
using SoftwareCompany.BLL.Activities.Activity.AccountActivity.GetAllAccount;
using SoftwareCompany.BLL.Activities.Activity.AccountActivity.Login;
using SoftwareCompany.BLL.Activities.Activity.CustomerActivity.GetAllCustomer;
using SoftwareCompany.BLL.Activities.Activity.CustomerActivity.GetCustomer;
using SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.CreateEmployee;
using SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetAllEmployee;
using SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetCountEmployeeById;
using SoftwareCompany.BLL.Activities.Activity.EmployeeActivity.GetEmployee;
using SoftwareCompany.BLL.Activities.Activity.ProjectActivity.CreateProject;
using SoftwareCompany.BLL.Activities.Activity.ProjectActivity.GetAllProject;
using SoftwareCompany.BLL.Activities.Activity.ProjectActivity.GetProjectById;
using SoftwareCompany.BLL.Activities.Activity.ProjectActivity.GetProjectByTeamId;
using SoftwareCompany.BLL.Activities.Activity.ProjectActivity.UpdateProject;
using SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.CreateProjectTask;
using SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetAllProjectTask;
using SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetCountProjectTaskByProjectId;
using SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetProjectTaskById;
using SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.GetTaskByEmployeeId;
using SoftwareCompany.BLL.Activities.Activity.ProjectTaskActivity.UpdateProjectTask;
using SoftwareCompany.BLL.Activities.Activity.TeamActivity.CreateTeam;
using SoftwareCompany.BLL.Activities.Activity.TeamActivity.GetAllTeam;
using SoftwareCompany.BLL.Activities.Activity.TeamActivity.GetTeam;
using SoftwareCompany.BLL.Activities.Contracts;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.CreateAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAccountByIdEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.GetAllAccountEvents;
using SoftwareCompany.BLL.DomainEvents.AccountEvents.LoginEvents;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetAllCustomerEvent;
using SoftwareCompany.BLL.DomainEvents.CustomerEvents.GetCustomerByIdEvent;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.CreateEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetAllEmployeeEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetCountEmployeeByTeamIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByAccountIdEvents;
using SoftwareCompany.BLL.DomainEvents.EmployeeEvents.GetEmployeeByIdEvents;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.CreateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetAllProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.GetProjectListByTeamIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectEvents.UpdateProjectEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.CreateProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetAllProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountSuccessTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetCountTaskByProjectIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetProjectTaskByIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.GetTaskListByEmployeeIdEvent;
using SoftwareCompany.BLL.DomainEvents.ProjectTaskEvents.UpdateProjectTaskEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.CreateTeamEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetAllTemEvent;
using SoftwareCompany.BLL.DomainEvents.TeamEvents.GetTeamByIdEvent;
using SoftwareCompany.BLL.Rules.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;
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
            this.ruleCollection.Add(typeof(IRequestActivity<LoginRequestEvent,LoginResponseEvent>), new GetAccountByRequest(repositoryFactory.Create<IAccountRepository>()));

            this.ruleCollection.Add(typeof(IValidationActivity<CreateAccountRequestEvent>), new CreateAccountValidationActivity(validationRuleFactory.Create<ICreateAccountOperationValidationRule>()));
            this.ruleCollection.Add(typeof(IRequestActivity<CreateAccountRequestEvent, CreateAccountResponseEvent>), new CreateAccountByRequest(repositoryFactory.Create<IAccountRepository>()));

            this.ruleCollection.Add(typeof(IRequestActivity<GetAccountByIdRequestEvent, GetAccountByIdResponseEvent>), new GetAccountById(repositoryFactory.Create<IAccountRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetAllAccountRequestEvent, GetAllAccountResponseEvent>), new GetAllAccountByRequest(repositoryFactory.Create<IAccountRepository>()));



            this.ruleCollection.Add(typeof(IRequestActivity<CreateEmployeeRequestEvent, CreateEmployeeResponseEvent>), new CreateEmployeeByRequest(repositoryFactory.Create<IEmployeeRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetEmployeeByIdRequestEvent, GetEmployeeByIdResponseEvent>), new GetEmployeeById(repositoryFactory.Create<IEmployeeRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetEmployeeByAccountIdRequestEvent, GetEmployeeByAccountIdResponseEvent>), new GetEmployeeByAccountId(repositoryFactory.Create<IEmployeeRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetAllEmployeeRequestEvent, GetAllEmployeeResponseEvent>), new GetAllEmployeeByRequest(repositoryFactory.Create<IEmployeeRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetCountEmployeeByTeamIdRequestEvent, GetCountEmployeeByTeamIdResponseEvent>), new GetCountEmployeeById(repositoryFactory.Create<IEmployeeRepository>()));

            this.ruleCollection.Add(typeof(IRequestActivity<CreateTeamRequestEvent, CreateTeamResponseEvent>),
                new CreateTeamByRequest(repositoryFactory.Create<ITeamRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetTeamByIdRequestEvent, GetTeamByIdResponseEvent>),
                new GetTeamById(repositoryFactory.Create<ITeamRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetAllTeamRequestEvent, GetAllTeamResponseEvent>),
                new GetAllTeamByRequest(repositoryFactory.Create<ITeamRepository>()));

            this.ruleCollection.Add(typeof(IRequestActivity<CreateProjectRequestEvent, CreateProjectResponseEvent>), new CreateProjectByRequest(repositoryFactory.Create<IProjectRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<UpdateProjectRequestEvent, UpdateProjectResponseEvent>), new UpdateProjectByRequest(repositoryFactory.Create<IProjectRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetAllProjectRequestEvent, GetAllProjectResponseEvent>), new GetAllProjectByRequest(repositoryFactory.Create<IProjectRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetProjectByIdRequestEvent, GetProjectByIdResponseEvent>), new GetProjectById(repositoryFactory.Create<IProjectRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetProjectByTeamIdRequestEvent, GetProjectByTeamIdResponseEvent>), new GetProjectByTeamId(repositoryFactory.Create<IProjectRepository>()));

            this.ruleCollection.Add(typeof(IRequestActivity<CreateProjectTaskRequestEvent, CreateProjectTaskResponseEvent>), new CreateProjectTaskByRequest(repositoryFactory.Create<IProjectTaskRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<UpdateProjectTaskRequestEvent, UpdateProjectTaskResponseEvent>), new UpdateProjectTaskByRequest(repositoryFactory.Create<IProjectTaskRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetAllProjectTaskRequestEvent, GetAllProjectTaskResponseEvent>), new GetAllProjectTaskByRequest(repositoryFactory.Create<IProjectTaskRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetProjectTaskByIdRequestEvent, GetProjectTaskByIdResponseEvent>), new GetProjectTaskById(repositoryFactory.Create<IProjectTaskRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetTaskListByEmployeeIdRequestEvent, GetTaskListByEmployeeIdResponseEvent>), new GetTaskByEmployeeId(repositoryFactory.Create<IProjectTaskRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetCountTaskByProjectIdRequestEvent, GetCountTaskByProjectIdResponseEvent>), new GetCountProjectTaskByProjectId(repositoryFactory.Create<IProjectTaskRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetCountSuccessTaskByProjectIdRequestEvent, GetCountSuccessTaskByProjectIdResponseEvent>), new GetCountSuccessProjectTaskByProjectId(repositoryFactory.Create<IProjectTaskRepository>()));
            
            
            this.ruleCollection.Add(typeof(IRequestActivity<GetAllCustomerRequestEvent, GetAllCustomerResponseEvent>), new GetAllCustomerByRequest(repositoryFactory.Create<ICustomerRepository>()));
            this.ruleCollection.Add(typeof(IRequestActivity<GetCustomerByIdRequestEvent, GetCustomerByIdResponseEvent>), new GetCustomerById(repositoryFactory.Create<ICustomerRepository>()));

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
