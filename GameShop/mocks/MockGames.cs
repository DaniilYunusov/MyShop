using GameShop.interfaces;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.mocks
{
    public class MockGames : IAllGames
    {
        private readonly IGamesCategory _categoryGames = new MockCategory();
        public IEnumerable<Game> Games
        {
            get
            {
                return new List<Game>
                {
                    new Game {
                        name = "Cyberpunk 2077",
                        shortDesc = "Мир, в котором люди едины с машинами",
                        longDesc = "Мультиплатформенная компьютерная игра в жанре Action/RPG",
                        img = "/img/Cyberpunk2077.jpeg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryGames.AllCategories.First()
                    },
                    new Game {
                        name = "Need for Speed Hot Pursuit Remastered",
                        shortDesc = "Пора вновь броситься в погоню!",
                        longDesc = "Увлекательная компьютерная игра серии Need for Speed в жанре аркадной автогонки.",
                        img = "/img/NeedforSpeedHotPursuitRemastered.jpg",
                        price = 3200,
                        isFavourite = true,
                        available = true,
                        Category = _categoryGames.AllCategories.Last()
                    },
                    new Game {
                        name = "Watch Dogs Legion",
                        shortDesc = "Добро пожаловать в сопротивление!",
                        longDesc = "Компьютерная игра в жанре Action-adventure",
                        img = "/img/WatchDogsLegion.jpg",
                        price = 4200,
                        isFavourite = false,
                        available = true,
                        Category = _categoryGames.AllCategories.First()
                    },
                    new Game {
                        name = "Forza Horizon 4",
                        shortDesc = "Живите жизнью горизонта!",
                        longDesc = "Захватывающая гоночная игра в жанре аркадного автосимулятора с открытым миром",
                        img = "/img/ForzaHorizon4.jpg",
                        price = 2100,
                        isFavourite = false,
                        available = true,
                        Category = _categoryGames.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Game> getFavGames { get; set; }

        public Game getObjectGame(int gameid)
        {
            throw new NotImplementedException();
        }
    }
}

