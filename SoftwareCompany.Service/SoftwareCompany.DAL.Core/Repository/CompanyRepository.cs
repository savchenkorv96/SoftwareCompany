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

        public IEnumerable<Company> GetCompanyList()
        {
            return Companies.ToList();
        }

        public Company GetCompanyById(int id)
        {
            return Companies.First((data) => data.Id == id);
        }

        public void CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void UpdateCompany(Company company)
        {
            var oldCompany = GetCompanyById(company.Id);
            oldCompany = company;
            _context.SaveChanges();
        }

        public void DeleteCompany(Company company)
        {
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }
    }
}
