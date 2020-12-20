using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.interfaces
{
    public interface IGamesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
