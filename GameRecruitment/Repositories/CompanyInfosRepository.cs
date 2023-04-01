using GameRecruitment.DataContext;
using GameRecruitment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRecruitment.Repositories
{
    public class CompanyInfosRepository
    {
        private readonly GamingClubDataContext _context;
        public CompanyInfosRepository(GamingClubDataContext context)
        {
            _context = context;
        }
        public DbSet<CompanyInfoModel> GetAllCompanies()
        {
            return _context.Companies;
        }

        public void Add(CompanyInfoModel model)
        {
            model.CompanyId=Guid.NewGuid();
            _context.Companies.Add(model);
            _context.SaveChanges();
        }
        public CompanyInfoModel GetCompaniesById(Guid id)
        {
            var company= _context.Companies.FirstOrDefault(a=>a.CompanyId==id);
            return company;
        }
        public void Update(CompanyInfoModel model)
        {
            _context.Companies.Update(model);
            _context.SaveChanges();
        }
        public void Delete(Guid id) 
        {
            CompanyInfoModel model=GetCompaniesById(id);
            _context.Companies.Remove(model);
            _context.SaveChanges();
        }
    }
}
