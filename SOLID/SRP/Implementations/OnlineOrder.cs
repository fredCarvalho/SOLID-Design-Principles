using SOLID.Models;
using SOLID.SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Implementations
{
    class OnlineOrder : Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        private readonly IReservationService _reservationService;

        public OnlineOrder(ShoppingCart shoppingCart, PaymentDetails paymentDetails, INotificationService notificationService, IPaymentService paymentService, IReservationService reservationService)
            : base(shoppingCart)
        {
            _paymentDetails = paymentDetails;
            _notificationService = notificationService;
            _paymentService = paymentService;
            _reservationService = reservationService;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            _reservationService.ReserveInventory(ShoppingCart.Items);
            _notificationService.NotifyCustomerOrderCreated(ShoppingCart);
            base.Checkout();
        }
    }
}
