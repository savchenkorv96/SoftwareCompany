using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Task> Tasks => _context.Tasks;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
