using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Activities.Contracts
{
    public interface IActivitiesFactory
    {
        T Create<T>();
    }
}
