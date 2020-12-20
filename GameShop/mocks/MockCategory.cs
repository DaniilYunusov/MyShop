using GameShop.interfaces;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.mocks
{
    public class MockCategory : IGamesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Шутеры", desc = "Игры-стреллялки"},
                    new Category { categoryName = "Гонки", desc = "Игры в которых ты учавствуешь в гоночных соревнованиях" }
                };
            }
        }
    }
}
