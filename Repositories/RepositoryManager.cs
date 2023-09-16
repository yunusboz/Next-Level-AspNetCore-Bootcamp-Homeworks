using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IOrderRepository _orderRepository;

        public RepositoryManager(
            RepositoryContext context,
            IEmployeeRepository employeeRepository,
            IOrderRepository orderRepository)
        {
            _context = context;
            _employeeRepository = employeeRepository;
            _orderRepository = orderRepository;
        }

        public IEmployeeRepository Employee => _employeeRepository;

        public IOrderRepository Order => _orderRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
