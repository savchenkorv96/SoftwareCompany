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
        void Create(T data);
        void Update(T data);
        void Delete(T data);
    }
}
