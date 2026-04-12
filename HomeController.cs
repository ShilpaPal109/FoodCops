using Crud_Operation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Operation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(PinCodeMaster pcm)
        {
            ViewBag.Message = pcm.Insert();
            return View();
        }
        public ActionResult Show()
        {
            PinCodeMaster pcm = new PinCodeMaster();
            List<PinCodeMaster> lst=pcm.ShowAll();
            return View(lst);
        }
        public ActionResult Delete(int Pincode)
        {
            PinCodeMaster pcm=new PinCodeMaster();
            TempData["Message"] = pcm.Delete(Pincode);
            return  RedirectToAction("Show");
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}