using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestJabil.Models;

namespace TestJabil.Controllers
{
    public class CustomerController : Controller
    {
        SqlContext sqlcontext = new SqlContext();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Building/Create
        [HttpGet]
        public ActionResult Create()
        {
            List<Building> model = sqlcontext.getAvailableBuildings();
            List<SelectListItem> item = model.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.BuildingName.ToString(),
                    Value = d.PKBuilding.ToString(),
                    Selected = false
                };
            });

            ViewBag.BuildingList = item;
            return PartialView("_CreatePartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                sqlcontext.runStoredProcedure(customer.customer, customer.Prefix, customer.FKBuilding);
                return RedirectToAction("Index");
            }
            ViewBag.BuildingList = new SelectList(sqlcontext.getAvailableBuildings(), "PKBuilding", "BuildingName");
            return PartialView("_CreatePartial", customer);
        }

    }
}