using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
