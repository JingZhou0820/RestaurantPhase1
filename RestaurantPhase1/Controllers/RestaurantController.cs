using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using RestaurantPhase1.Models;
namespace RestaurantPhase1.Controllers
{
    public class RestaurantController : Controller
    {
        RestaurantContext db = new RestaurantContext();
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult List(string searchby)
        {

            if (searchby == null || searchby == string.Empty)
            {
                return View(db.Restaurants.ToList());
            }

            else
            {

                return View(db.Restaurants.Where(x => x.Name.Contains(searchby.ToLower()) || x.Type.Contains(searchby.ToLower()) || x.Area.Contains(searchby.ToLower()) || x.Description.Contains(searchby.ToLower()) || x.City.Contains(searchby.ToLower())).ToList());
            }
        }
    }
}
