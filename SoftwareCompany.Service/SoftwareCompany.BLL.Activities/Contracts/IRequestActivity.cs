using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Activities.Contracts
{
    public interface IRequestActivity<in T, out TO>
    {
        TO Execute(T request);
    }
}
