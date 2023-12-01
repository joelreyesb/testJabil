using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestJabil.Controllers
{
    public class PartNumbersController : Controller
    {
        // GET: PartNumbers
        public ActionResult Index()
        {
            return View();
        }

        // GET: PartNumbers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartNumbers/Create
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
    }
}
