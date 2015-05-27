using FlooringCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlooringCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View(new Flooring());
        }

        // POST: Home/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Width,Length,CostPerUnitOfFlooring")] Flooring floor)
        {
            if (ModelState.IsValid)
            {
                floor.TotalCost = (decimal)floor.Width * (decimal)floor.Length * floor.CostPerUnitOfFlooring;
            }
            return View(floor);
        }
    }
}