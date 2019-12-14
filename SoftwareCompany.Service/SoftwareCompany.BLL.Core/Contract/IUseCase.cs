using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.BLL.Core.Contract
{
    public interface IUseCase<in TRequest, out TResponse>
    {
        TResponse Execute(TRequest request);
    }
}
