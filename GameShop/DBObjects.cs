using GameShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
                     

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Game.Any())
            {
                content.AddRange(
                    new Game
                    {
                        name = "Cyberpunk 2077",
                        shortDesc = "Мир, в котором люди едины с машинами",
                        longDesc = "Мультиплатформенная компьютерная игра в жанре Action/RPG",
                        img = "/img/Cyberpunk2077.jpeg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Шутеры"]
                    },
                    new Game
                    {
                        name = "Need for Speed Hot Pursuit Remastered",
                        shortDesc = "Пора вновь броситься в погоню!",
                        longDesc = "Увлекательная компьютерная игра серии Need for Speed в жанре аркадной автогонки.",
                        img = "/img/NeedforSpeedHotPursuitRemastered.jpg",
                        price = 3200,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Гонки"]
                    },
                    new Game
                    {
                        name = "Watch Dogs Legion",
                        shortDesc = "Добро пожаловать в сопротивление!",
                        longDesc = "Компьютерная игра в жанре Action-adventure",
                        img = "/img/WatchDogsLegion.jpg",
                        price = 4200,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Шутеры"]
                    },
                    new Game
                    {
                        name = "Forza Horizon 4",
                        shortDesc = "Живите жизнью горизонта!",
                        longDesc = "Захватывающая гоночная игра в жанре аркадного автосимулятора с открытым миром",
                        img = "/img/ForzaHorizon4.jpg",
                        price = 2100,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Гонки"]
                    }
                    );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Шутеры", desc = "Игры-стреллялки"},
                        new Category { categoryName = "Гонки", desc = "Игры в которых ты учавствуешь в гоночных соревнованиях" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
