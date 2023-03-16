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
    }
}
