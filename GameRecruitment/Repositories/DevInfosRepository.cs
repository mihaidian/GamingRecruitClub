using GameRecruitment.DataContext;
using GameRecruitment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRecruitment.Repositories
{
    public class DevInfosRepository
    {
        private readonly GamingClubDataContext _context;
        public DevInfosRepository(GamingClubDataContext context)
        {
            _context = context;
        }
        public DbSet<DevInfoModel> GetAllDevs()
        {
            return _context.Devs;
        }
        public void Add(DevInfoModel model) 
        {
            model.DevID=Guid.NewGuid();
            _context.Devs.Add(model);
            _context.SaveChanges();

        }
        public DevInfoModel GetDevsByID(Guid id)
        {
            DevInfoModel model = _context.Devs.FirstOrDefault(x => x.DevID == id);
            return model;
        }
        public void Update(DevInfoModel model) 
        {
            _context.Devs.Update(model);
            _context.SaveChanges();
        }
        public void Delete(Guid id) 
        {
            DevInfoModel model = GetDevsByID(id);
            _context.Devs.Remove(model);
            _context.SaveChanges();
        }
    }
}
