using catering.Core.Entitys;
using catering.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catering.Data.Repositories
{
    public class DishesRepository: IDishesRepository
    {
        private readonly DataContext _context;
        public DishesRepository(DataContext context)
        {
            _context = context;
        }
        public List<Dish> GetList()
        {
            return _context.Dishes.Include(u => u.Resources).ToList();
        }


    }
}

