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
    public class DishesService:IDishesService
    {
        private readonly IDishesRepository _dishesService;

        public DishesService(IDishesRepository dishesService)
        {
            _dishesService = dishesService;
        }
        public List<Dish> GetAll()
        {
            return _dishesService.GetList();
        }
    }
}
