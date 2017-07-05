using SpodIgly.DAL;
using SpodIgly.Infrastructure;
using SpodIgly.Models;
using SpodIgly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIgly.Controllers
{
    public class HomeController : Controller
    {

        private StoreContext db = new StoreContext();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var genres = db.Genres.ToList();

            ICacheProvider cache = new DefaultCacheProvider();
            List<Album> newArrivals;

            if (cache.IsSet(Consts.NewItemCacheKey))
            {
                newArrivals = cache.Get(Consts.NewItemCacheKey) as List<Album>;
            }
            else
            {
                newArrivals = db.Albums.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
                cache.Set(Consts.NewItemCacheKey, newArrivals, 1000);
            }
                      
            var bestsellers = db.Albums.Where(a => !a.IsHidden && a.IsBestseller).OrderBy(g => Guid.NewGuid()).Take(3).ToList();

            var viewModel = new HomeViewModel()
            {
                Genres = genres,
                NewArrivals = newArrivals,
                Bestsellers = bestsellers
            };
          
            return View(viewModel);
        }

        public ActionResult StaticContent(string viewname)
        {

            return View(viewname);
        }
	}
}