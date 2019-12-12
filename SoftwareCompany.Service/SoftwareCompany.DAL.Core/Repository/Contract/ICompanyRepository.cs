using System;
using System.Collections.Generic;
using System.Text;
using SoftwareCompany.DAL.Common.Entities;

namespace SoftwareCompany.DAL.Core.Repository.Contract
{
    public interface ICompanyRepository : IRepository
    {
        IEnumerable<Company> Companies { get; }

        IEnumerable<Company> GetCompanyList();
        Company GetCompanyById(int id);
        void CreateCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);

    }
}
