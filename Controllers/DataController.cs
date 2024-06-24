using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Crud.Models;
namespace MVC_Crud.Controllers
{
    public class DataController : Controller
    {
        Datacontext db = new Datacontext();
        // GET: Data
        public ActionResult Index()
        {
            List<Data> data = new List<Data>();
            data = db.datas.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Data data = new Data();
            db.datas.Add(data);
            return View();
        }
        [HttpPost]
        public ActionResult Create( Data data)
        {
            if(ModelState.IsValid)
            {
                db.datas.Add(data);
                db.SaveChanges();
                Response.Redirect("index");
            }
            return View();
        }
    }
}