using FoodMenuPortalWeb.Models;
using FoodMenuPortalWeb.Repositories;
using FoodMenuPortalWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodMenuPortalWeb.Controllers
{
    public class FoodMenuController : Controller
    {
        private FoodMenuRepository _foodMenuRepository;
        private FoodMenuItemRepository _foodMenuItemRepository;

        public FoodMenuController()
        {
            _foodMenuRepository = new FoodMenuRepository();
            _foodMenuItemRepository = new FoodMenuItemRepository();
        }

        // GET: FoodMenu
        [HttpGet]
        public ActionResult Index()
        {
            List<FoodMenu> foodMenuList = _foodMenuRepository.List();
            
            return View(new FoodMenuListViewModel() { FoodMenus = foodMenuList });
        }

        [HttpGet]
        public ActionResult Id(Guid id)
        {
            List<FoodMenuItem> foodMenuItemList = _foodMenuItemRepository.List(id);

            return View(new FoodMenuItemListViewModel(id) { FoodMenuItems = foodMenuItemList });
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FoodMenu form)
        {
            form.Id = Guid.NewGuid();
            form.CreatedOn = DateTime.Now;
            _foodMenuRepository.Add(form);

            return Redirect("Index");
        }
    }
}