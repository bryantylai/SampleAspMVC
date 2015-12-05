using FoodMenuPortalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenuPortalWeb.Repositories
{
    public class FoodMenuRepository
    {
        private DatabaseEntities _dataEntities;

        public FoodMenuRepository()
        {
            _dataEntities = new DatabaseEntities();
        }

        public List<FoodMenu> List()
        {
            return _dataEntities.FoodMenus.OrderByDescending(f => f.CreatedOn).ToList();
        }

        public FoodMenu Get(Guid id)
        {
            return _dataEntities.FoodMenus.FirstOrDefault(f => f.Id == id);
        }

        public bool Add(FoodMenu foodMenu)
        {
            _dataEntities.FoodMenus.Add(foodMenu);
            return _dataEntities.SaveChanges() > 1;
        }
    }
}
