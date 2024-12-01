using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.DIP
{
    // High-level module
  public  class OrderService
    {
        private readonly INotificationService _notificationService;

        // Constructor Injection
        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Order placed.");
            _notificationService.Notify("Order confirmation notification.");
        }
    }

}
