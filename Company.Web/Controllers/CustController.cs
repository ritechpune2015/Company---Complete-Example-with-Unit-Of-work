using Company.Core;
using Company.Infra;
using Company.Infra.Interfaces;
using Company.Infra.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Web.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        IUnitWork crepo;
        public CustController(IUnitWork ctemp)
        {
            this.crepo = ctemp;
        }
        public ActionResult Index()
        {
            return View(this.crepo.customers.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer rec)
        {
            if (ModelState.IsValid)
            {
                this.crepo.customers.Add(rec);
                this.crepo.Complete();
                return RedirectToAction("Index");
            }

            return View(rec);
        }
    }
}