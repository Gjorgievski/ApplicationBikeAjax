using ApplicationBike.BusinessLayer;
using ApplicationBike.BusinessLayer.Contracts;
using ApplicationBike.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationBike.Controllers
{
    public class BikeController : Controller
    {
        // GET: Bike
        public ActionResult Index()
        {


            return View();
        }

        // GET: Bike/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bike/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bike/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bike/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bike/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bike/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bike/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bike JSON
        [HttpPost]
        public ActionResult GetBikes(string SearchRegNumber, string SearchProducer, string SearchColour)
        {


            //call BL
            BikeSearchCommand _command = new BikeSearchCommand();
            _command.RegNumber = SearchRegNumber;
            _command.Producer = SearchProducer;
            _command.Colour = SearchColour;
           
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
           

            return Json(_result.Result, JsonRequestBehavior.AllowGet);
            
        }
    }

}
