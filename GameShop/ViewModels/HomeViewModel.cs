﻿using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> favGames { get; set; }
    }
}
