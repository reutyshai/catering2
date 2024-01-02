using catering.Core.Entitys;
using catering.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catering.Data.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> GetList()
        {
            return _context.Customers.ToList();
        }
    }
}
