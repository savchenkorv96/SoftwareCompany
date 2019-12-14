using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Rules.Contract
{
    public interface IValidationRuleFactory
    {
        T Create<T>();
    }
}
