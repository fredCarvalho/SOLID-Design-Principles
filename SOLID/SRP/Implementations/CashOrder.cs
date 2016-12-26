using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Implementations
{
    public class CashOrder : Order
    {
        public CashOrder(ShoppingCart shoppingCart) : base(shoppingCart)
        {

        }
    }
}
