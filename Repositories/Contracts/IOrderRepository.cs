using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetAllOrders(bool trackChanges);
        //IQueryable<Order> GetAllOrderForEmployee(int  employeeId, bool trackChanges);
        Order? GetOneOrder(int orderId, bool trackChanges);

    }
}
