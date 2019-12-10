using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface ITaskRepository : IRepository
    {
        IEnumerable<Task> Tasks { get; }
    }
}
