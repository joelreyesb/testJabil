using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestJabil.Models;

namespace TestJabil.Controllers
{
    public class BuildingController : Controller
    {
        SqlContext sqlcontext = new SqlContext();
        // GET: Building
        public ActionResult Index()
        {
            return View();
        }

        // GET: Building/Create
        [HttpGet]
        public ActionResult AddBuilding()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Building buiding)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BuildingList = new SelectList(sqlcontext.getAvailableBuildings(), "PKBuilding", "BuildingName");
                sqlcontext.runStoredProcedure(buiding.BuildingName);
                return RedirectToAction("Index");
            }
            return View(buiding);
        }
       
    }
}
