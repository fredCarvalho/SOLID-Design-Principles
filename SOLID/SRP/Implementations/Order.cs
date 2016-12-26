using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public abstract class Order
    {
        private readonly ShoppingCart _shoppingCart;

        public Order(ShoppingCart shoppingCart)
        {
            this._shoppingCart = shoppingCart;
        }

        public ShoppingCart ShoppingCart {
            get
            {
                return this._shoppingCart;
            }
        }

        public virtual void Checkout()
        {
            //add common functionality to all Checkout operations
        }
    }
}
