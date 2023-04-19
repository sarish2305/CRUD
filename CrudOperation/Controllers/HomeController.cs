using CrudOperation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperation.Controllers
{
    public class HomeController : Controller
    {
        private object table_1model;

        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //public Table_1 GetTable_1()
        //{
        //    return Table_1;
        //}

        //[HttpPost]
        ////public ActionResult Create(table_1model)
        ////{
        //    //_context.Table_1.Add(table_1model);
        //    //_context.SaveChanges();
        //    ViewBag.Message = "Data Insert Successfully";
        //    return View();
        //}
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}