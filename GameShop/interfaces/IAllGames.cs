using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.interfaces
{
    public interface IAllGames
    {
        IEnumerable<Game> Games { get; }
        IEnumerable<Game> getFavGames { get; set; }
        Game getObjectGame(int gameid);
    }
}
