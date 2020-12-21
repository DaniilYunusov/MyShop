using GameShop.interfaces;
using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Repository
{
    public class CategoryRepository : IGamesCategory
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
