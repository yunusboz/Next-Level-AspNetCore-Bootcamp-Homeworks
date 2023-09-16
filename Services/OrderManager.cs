using Domain.Entities;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderManager : IOrderService
    {
        private readonly IRepositoryManager _repositoryManager;

        public OrderManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IEnumerable<Order> GetAllOrders(bool trackChanges)
        {
            return _repositoryManager.Order.GetAllOrders(trackChanges);
        }

        public Order? GetOneOrder(int id, bool trackChanges)
        {
            var order = _repositoryManager.Order.GetOneOrder(id, trackChanges);
            if(order is null)
            {
                throw new Exception($"Order with {id} not found!");
            }
            return order;
        }
    }
}
