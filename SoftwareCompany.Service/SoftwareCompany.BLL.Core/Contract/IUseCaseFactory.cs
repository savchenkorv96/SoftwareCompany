using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Core.Contract
{
    public interface IUseCaseFactory
    {
        T Create<T>();
    }
}
