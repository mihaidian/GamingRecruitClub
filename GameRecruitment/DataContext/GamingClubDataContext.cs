using GameRecruitment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRecruitment.DataContext
{
    public class GamingClubDataContext :DbContext
    {
        public GamingClubDataContext (DbContextOptions<GamingClubDataContext>  options) : base(options) { }
        public DbSet<DevInfoModel> Devs { get; set; }
        public DbSet<GameInfoModel> Games { get; set; }
        public DbSet<TesterInfoModel> Testers{ get; set; }
        public DbSet<CompanyInfoModel> Companies { get; set; }
        public DbSet<GameRecruitment.Models.ContactUsModel>? ContactUsModel { get; set; }
    }
}
