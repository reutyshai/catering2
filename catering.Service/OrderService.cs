using catering.Core.Entitys;
using catering.Core.Repositories;
using catering.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catering.Service
{
    public class OrderService:IOrderService
    {

        private readonly IOrderRepository _orderService;

        public OrderService(IOrderRepository orderService)
        {
            _orderService = orderService;
        }
        public List<Order> GetAll()
        {
            return _orderService.GetList();
        }
    }
}
