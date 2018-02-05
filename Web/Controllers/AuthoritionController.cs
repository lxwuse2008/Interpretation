using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Base;

namespace Web.Controllers
{
    public class AuthoritionController : BaseController
    {
        // GET: Authorition
        public ActionResult Index()
        {
            return View();
        }
    }
}