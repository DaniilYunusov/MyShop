using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameShop.Models;
using GameShop.interfaces;
using GameShop.ViewModels;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllGames _gameRep;

        public HomeController(IAllGames gameRep)
        {
            _gameRep = gameRep;
        }

        public ViewResult Index()
        {
            var homeGames = new HomeViewModel
            {
                favGames = _gameRep.getFavGames
            };
            return View(homeGames);
        }
    }
}
