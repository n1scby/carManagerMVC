using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using carManagerMVC.Models;
using Microsoft.AspNetCore.Authorization;
using nb.VehicleLibrary1;

namespace carManagerMVC.Controllers
{
    public class HomeController : Controller
    {
        private VehicleRepository _vehRepo = new VehicleRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var myCar = new Car
            {
                Year = 2015,
                Make = "Honda",
                Model = "Accord",
                NumberOfDoors = 4
            };

            _vehRepo.Add(myCar);
            return View(myCar);
        }

        [Authorize]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
