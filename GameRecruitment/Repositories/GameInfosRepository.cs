using GameRecruitment.DataContext;
using GameRecruitment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRecruitment.Repositories
{
    public class GameInfosRepository
    {
        private readonly GamingClubDataContext _context;
        public GameInfosRepository(GamingClubDataContext context)
        {
            _context = context;
        }
        public DbSet<GameInfoModel> GetGameInfos()
        {
            return _context.Games;
        }
        public void Add(GameInfoModel model) 
        {
            model.GameID = Guid.NewGuid();
            _context.Games.Add(model);
            _context.SaveChanges();
        }
        public GameInfoModel GetGameByID(Guid id) 
        {
            GameInfoModel model=_context.Games.FirstOrDefault(x=>x.GameID == id);
            return model;
        }
        public void Update(GameInfoModel model) 
        {
            GameInfoModel game=GetGameByID(model.GameID);
            if(game != null) 
            {
                _context.Games.Update(game);
                _context.SaveChanges();
            }
        }
        public void Delete(Guid id)
        {
            GameInfoModel game=GetGameByID(id);
            if (game != null)
            {
                _context.Games.Remove(game);
                _context.SaveChanges();
            }

        }
    }
}
