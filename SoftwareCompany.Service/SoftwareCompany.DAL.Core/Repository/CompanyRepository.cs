using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;
using SoftwareCompany.DAL.Core.Repository.Contract;

namespace SoftwareCompany.DAL.Core.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Company> Companies => _context.Companies;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
