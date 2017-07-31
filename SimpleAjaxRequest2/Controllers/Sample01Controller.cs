using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample2.Models;

namespace SimpleAjaxRequest2.Controllers
{
    public class Sample01Controller : Controller
    {
        // GET: Sample01
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public string Index(string txtFirstNo, string txtSecondNo)
        //{
        //    return (int.Parse(txtFirstNo) + int.Parse(txtSecondNo)).ToString();
        //}

        [HttpPost]
        public string Index(SampleViewModel m)
        {
            return (int.Parse(m.txtFirstNo) + int.Parse(m.txtSecondNo)).ToString();
        }
    }
}