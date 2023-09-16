using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IEmployeeService _employeeService;
        private readonly IOrderService _orderService;

        public ServiceManager(
            IEmployeeService employeeService,
            IOrderService orderService)
        {
            _employeeService = employeeService;
            _orderService = orderService;
        }

        public IEmployeeService EmployeeService => _employeeService;

        public IOrderService OrderService => _orderService;
    }
}
