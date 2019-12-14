using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.BLL.Rules.Contract;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation;
using SoftwareCompany.BLL.Rules.Validation.Operations.AccountOperation.Contract;

namespace SoftwareCompany.BLL.Rules.Factory
{
    public class ValidationRuleFactory : IValidationRuleFactory
    {
        readonly Dictionary<Type, object> ruleCollection = new Dictionary<Type, object>();

        public ValidationRuleFactory()
        {
            // Extension point of the factory
            this.ruleCollection.Add(typeof(ILoginOperationValidationRule), new LoginOperationValidationRule());
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
