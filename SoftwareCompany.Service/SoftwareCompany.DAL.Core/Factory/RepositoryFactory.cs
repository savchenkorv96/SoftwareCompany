using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Core.Factory.Contract;
using SoftwareCompany.DAL.Core.Repository;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Factory
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly Dictionary<Type, object> _collection = new Dictionary<Type,object>();

        public RepositoryFactory(ApplicationDbContext context)
        {
            this._collection.Add(typeof(IAccountRepository), new AccountRepository(context));
            this._collection.Add(typeof(ICompanyRepository), new CompanyRepository(context));
            this._collection.Add(typeof(ICustomerRepository), new CustomerRepository(context));
            this._collection.Add(typeof(ITeamRepository), new TeamRepository(context));
            this._collection.Add(typeof(IEmployeeRepository), new EmployeeRepository(context));
            this._collection.Add(typeof(IProjectRepository), new ProjectRepository(context));
            this._collection.Add(typeof(ITaskRepository), new TaskRepository(context));
        }
        public T Create<T>()
        {
            Type type = typeof(T);

            if (!this._collection.ContainsKey(type))
            {
                throw new MissingMemberException(type.ToString() + " is missing in the collection");
            }

            return (T) this._collection[type];
        }
    }
}
