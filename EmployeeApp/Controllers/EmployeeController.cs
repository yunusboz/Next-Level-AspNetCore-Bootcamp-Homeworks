using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IServiceManager _manager;

        public EmployeeController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var employees = _manager.EmployeeService.GetAllEmployees(false);
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _manager.EmployeeService.CreateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
