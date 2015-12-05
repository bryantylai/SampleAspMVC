using FoodMenuPortalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenuPortalWeb.ViewModels
{
    public class FoodMenuItemListViewModel
    {
        public FoodMenuItemListViewModel(Guid foodMenuId)
        {
            FoodMenuId = foodMenuId;
        }

        public Guid FoodMenuId { get; private set; }
        public List<FoodMenuItem> FoodMenuItems { get; set; }
    }
}
