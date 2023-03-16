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

    }
}
