using GameRecruitment.DataContext;
using GameRecruitment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRecruitment.Repositories
{
    public class TesterInfosRepository
    {
        private readonly GamingClubDataContext _context;

        public TesterInfosRepository(GamingClubDataContext context)
        {
            _context = context;
        }
        public DbSet<TesterInfoModel> GetAllTesters()
        {
            return _context.Testers;
        }
        public void Add(TesterInfoModel model)
        {
            model.TesterID= Guid.NewGuid();
            _context.Testers.Add(model);
            _context.SaveChanges();
        }
        public TesterInfoModel GetTesterByID(Guid id)
        {
            TesterInfoModel model = _context.Testers.FirstOrDefault(x => x.TesterID == id);
            return model;
        }
        public void Update(TesterInfoModel model) 
        {

            _context.Testers.Update(model);
            _context.SaveChanges();
        }
        public void Delete(Guid id) 
        {
            TesterInfoModel model= GetTesterByID(id);
            _context.Testers.Remove(model);
            _context.SaveChanges();
        }
    }
}
