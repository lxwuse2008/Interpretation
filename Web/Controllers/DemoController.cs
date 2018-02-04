using Service.Impl;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Base;

namespace Web.Controllers
{
    public class DemoController : BaseController
    {
        private readonly IDemoService demoSerivce;
        public DemoController()
        {
            demoSerivce = new DemoService();
        }

        // GET: Demo
        public ActionResult Index()
        {
            var id = demoSerivce.Add(new Model.DemoModel() { Demo = "Add" });
            var model = demoSerivce.GetById(id);
            model.Demo = "Update";
            demoSerivce.Update(model);
            demoSerivce.Delete(id);
            return View();
        }
    }
}