using GameShop.interfaces;
using GameShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly AppDBContent appDBContent;

        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Game> Games => appDBContent.Game.Include(c => c.Category);

        public IEnumerable<Game> getFavGames => appDBContent.Game.Where(p => p.isFavourite).Include(c => c.Category);

        public Game getObjectGame(int gameid) => appDBContent.Game.FirstOrDefault(p => p.id == gameid);
        
    }
}
