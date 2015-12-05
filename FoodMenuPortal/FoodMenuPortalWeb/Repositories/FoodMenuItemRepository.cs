using FoodMenuPortalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenuPortalWeb.Repositories
{
    public class FoodMenuItemRepository
    {
        private DatabaseEntities _dataEntities;

        public FoodMenuItemRepository()
        {
            _dataEntities = new DatabaseEntities();
        }

        public List<FoodMenuItem> List(Guid foodMenuId)
        {
            return _dataEntities.FoodMenuItems.Where(f => f.FoodMenuId == foodMenuId).OrderByDescending(f => f.CreatedOn).ToList();
        }

        public FoodMenuItem Get(Guid id)
        {
            return _dataEntities.FoodMenuItems.FirstOrDefault(f => f.Id == id);
        }

        public bool Add(FoodMenuItem foodMenuItem)
        {
            _dataEntities.FoodMenuItems.Add(foodMenuItem);
            return _dataEntities.SaveChanges() > 1;
        }
    }
}
