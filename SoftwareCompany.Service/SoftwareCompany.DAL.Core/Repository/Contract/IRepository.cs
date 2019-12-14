using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(T data);
        bool Create(T data);
        bool Update(T data);
        bool Delete(T data);
    }
}
