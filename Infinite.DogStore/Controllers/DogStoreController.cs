using Infinite.DogStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinite.DogStore.Controllers
{
    public class DogStoreController : Controller
    {
        private readonly ApplicationDbContext _context = null;

        public DogStoreController() 
        {
            _context = new ApplicationDbContext();
        }



        public ActionResult Index()
        {
            var dogs = _context.Dogs.ToList();
            return View(dogs);
        }
        public ActionResult Create ()
        {
            var dogbreed=_context.DogBreeds.ToList();
            ViewBag.DogBreeds=dogbreed;
            return View();

        }
        [HttpPost]
        public ActionResult Create(Dogs dogs)
        {
            if(ModelState.IsValid)
            {
                _context.Dogs.Add(dogs);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            var dogbreed = _context.DogBreeds.ToList();
            ViewBag.DogBreeds=dogbreed;
            return View();
        }
}
}