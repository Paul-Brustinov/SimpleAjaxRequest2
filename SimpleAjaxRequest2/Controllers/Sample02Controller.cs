using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample2.Models;

namespace Sample2.Controllers
{
    public class Sample02Controller : Controller
    {
        // GET: Sampl02
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(SampleViewModel m)
        {
            return (int.Parse(m.txtFirstNo) + int.Parse(m.txtSecondNo)).ToString();
        }

    }
}