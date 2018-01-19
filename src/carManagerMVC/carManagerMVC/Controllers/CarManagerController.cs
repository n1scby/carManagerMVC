using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nb.VehicleLibrary1;

namespace carManagerMVC.Controllers
{
    public class CarManagerController : Controller
    {
        private static VehicleRepository _vehicleRepo = new VehicleRepository();
        // GET: CarManager
        public ActionResult Index()
        {
            return View(_vehicleRepo.ListAll());
        }

        // GET: CarManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_vehicleRepo.GetById(id));
        }

        // GET: CarManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehicle newVehicle, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                _vehicleRepo.Add(newVehicle);

           
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_vehicleRepo.GetById(id));
        }

        // POST: CarManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vehicle editVehicle, int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _vehicleRepo.Edit(editVehicle);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_vehicleRepo.GetById(id));
        }

        // POST: CarManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _vehicleRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}