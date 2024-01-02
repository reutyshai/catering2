using catering.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catering.Core.Services
{
    public interface IDishesService
    {
        List<Dish> GetAll();
    }
}
