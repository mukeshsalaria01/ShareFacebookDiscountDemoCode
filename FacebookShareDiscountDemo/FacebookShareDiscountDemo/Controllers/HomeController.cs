using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacebookShareDiscountDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FacebookShare()
        {
            return View();
        }

        /// <summary>
        /// Callback from facebook after share
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="socialId"></param>
        /// <returns></returns>
        public ActionResult UpdateSocialShareId(string userId, string socialId)
        {
            try
            {
                if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(socialId))
                {
                   //Here you can add entry into your database that social id return from the facebook callback
                   //You can check if that social share id isn't null then give discount you want on current transaction
                    //Or next transaction.
                }

                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }
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