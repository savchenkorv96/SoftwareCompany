using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.DAL.Core.Factory.Contract
{
    public interface IRepositoryFactory
    {
        T Create<T>();
    }
}
