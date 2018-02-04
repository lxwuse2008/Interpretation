using Model;
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
        private IDemoService demoService;
        public DemoController()
        {
            demoService = new DemoService();
        }
        // GET: Demo
        public ActionResult Index()
        {
            var model = demoService.GetById(1);
            var i = demoService.Add(new DemoModel() { Demo = "Add" });
            demoService.Update(new DemoModel() { Demo = "Update", Id = i });
            demoService.Delete(i);
            return View();
        }
    }
}