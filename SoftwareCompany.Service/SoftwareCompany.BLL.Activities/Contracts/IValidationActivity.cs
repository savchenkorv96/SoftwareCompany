using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Activities.Contracts
{
    public interface IValidationActivity<in T>
    {
        void Validate(T request);
    }
}
