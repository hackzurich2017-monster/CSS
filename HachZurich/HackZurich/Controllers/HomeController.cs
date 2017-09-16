using HackZurich.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackZurich.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ArrayList st = PictureLabelClient.getDescriptionOfPicture();
            ViewBag.Title = "Home Screen";
            ViewBag.Items = String.Join(", ", st.ToArray());

            return View();
        }
    }
}
