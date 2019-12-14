using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company GetById(Company data)
        {
            throw new NotImplementedException();
        }

        public Company Create(Company data)
        {
            throw new NotImplementedException();
        }

        public Company Update(Company data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Company data)
        {
            throw new NotImplementedException();
        }
    }
}
