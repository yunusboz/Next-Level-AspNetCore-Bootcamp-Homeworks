using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders(bool trackChanges);
        Order? GetOneOrder(int id, bool trackChanges);
    }
}
