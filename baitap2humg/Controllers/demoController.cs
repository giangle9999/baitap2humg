using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap2humg.Models;

namespace baitap2humg.Controllers
{
    public class demoController : Controller
    {
        giaiphuongtrinh gpt = new giaiphuongtrinh();
        // GET: demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double hesoa, double heosob)
        {
            double x = gpt.giaiphuongtrinhbacnhat(hesoa, heosob);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}