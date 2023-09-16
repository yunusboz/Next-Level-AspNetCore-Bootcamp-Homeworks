using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace EmployeeApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IServiceManager _manager;

        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index([FromRoute(Name = "id")] int id)
        {
            var ordersOfEmployee = _manager.OrderService.GetAllOrders(false)
                                    .Where(o => o.EmployeeId.Equals(id));
            return View(ordersOfEmployee);
        }
    }
}
