using SpodIgly.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace SpodIgly.Controllers
{
    public class StoreController : Controller
    {
        StoreContext db = new StoreContext();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);

            return View(album);
        }

        public ActionResult List(string genrename)
        {
            var genre = db.Genres.Where(g => g.Name.ToUpper() == genrename.ToUpper()).Single();
            var albums = genre.Albums.ToList();

            return View(albums);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 80000)]
        public ActionResult GenresMenu()
        {
            var genres = db.Genres.ToList();

            return PartialView("_GenresMenu",genres);
        }
	}
}