using GameShop.interfaces;
using GameShop.Models;
using GameShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Controllers
{
    public class GamesController: Controller
    {
        private readonly IAllGames _allGames;
        private readonly IGamesCategory _allCategories;

        public GamesController(IAllGames iAllGames, IGamesCategory iGamesCat)
        {
            _allGames = iAllGames;
            _allCategories = iGamesCat;
        }

        [Route("Games/List")]
        [Route("Games/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Game> games = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                games = _allGames.Games.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("shooter", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.categoryName.Equals("Шутеры")).OrderBy(i => i.id);
                    currCategory = "Шутеры";
                }
                else if (string.Equals("race", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.categoryName.Equals("Гонки")).OrderBy(i => i.id);
                    currCategory = "Гонки";
                }
            }
            var gameObj = new GamesListViewModel
                {
                    allGames = games,
                    currCategory = currCategory
                };


            ViewBag.Title = "Страница с играми";
            
            return View(gameObj);
        }
    }
}
