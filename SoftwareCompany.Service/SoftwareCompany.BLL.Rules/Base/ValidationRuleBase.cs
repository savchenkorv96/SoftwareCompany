using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Rules.Base
{
    public abstract class ValidationRuleBase
    {
        protected string ruleDescription;

        public ValidationRuleBase(string ruleDescription)
        {
            this.ruleDescription = ruleDescription;
        }
        protected virtual string GetErrorMessage()
        {
            return ruleDescription;
        }
    }
}
