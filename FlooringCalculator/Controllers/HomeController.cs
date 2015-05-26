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
        public ActionResult Index()
        {
            return View(new Flooring());
        }

        // GET
        public ActionResult Calculate(double length = 0, double width = 0, decimal costPerUnitOfFlooring = 0)
        {
            var calculation = new Flooring
            {
                Length = length,
                Width = width,
                CostPerUnitOfFlooring = costPerUnitOfFlooring,
                TotalCost = (decimal)length * (decimal)width * costPerUnitOfFlooring
            };
            return View(calculation);
        }
    }
}