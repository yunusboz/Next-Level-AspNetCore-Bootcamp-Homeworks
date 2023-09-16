using Domain.Entities;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context) : base(context)
        {
        }

        //public IQueryable<Order> GetAllOrderForEmployee(int employeeId, bool trackChanges) => Fi

        public IQueryable<Order> GetAllOrders(bool trackChanges) => FindAll(trackChanges);

        public Order? GetOneOrder(int orderId, bool trackChanges) => FindByCondition(o => o.OrderId.Equals(orderId), false);
    }
}
