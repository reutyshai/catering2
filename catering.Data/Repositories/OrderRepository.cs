using catering.Core.Entitys;
using catering.Core.Repositories;
using catering.Core.Repositories;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catering.Data.Repositories
{
    public class OrderRepository: IOrderRepository
    {

        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Order> GetList()
        {
            return _context.Orders.Include(u => u.Resources).ToList();
        }
    }
}
