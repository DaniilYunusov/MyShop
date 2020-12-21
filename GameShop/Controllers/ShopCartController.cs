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
    public class ShopCartController : Controller
    {
        private readonly IAllGames _gameRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllGames gameRep, ShopCart shopCart)
        {
            _gameRep = gameRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _gameRep.Games.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
