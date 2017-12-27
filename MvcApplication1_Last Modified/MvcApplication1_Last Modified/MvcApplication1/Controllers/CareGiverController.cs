using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.ViewModels;

namespace MvcApplication1.Controllers
{
    public class CareGiverController : Controller
    {
        //
        // GET: /CareGiver/

        public ActionResult CareGiverRegistration()
        {

            return View( new CareGiverRegisterModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult CareGiverRegistration(CareGiverRegisterModel cr)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("step2"); 
            }
            else
            {
                return View();
            }
        }
        public ActionResult step2()
        {

            return View(new RegistrationStep2Model());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult step2(RegistrationStep2Model cr)
        {

            return RedirectToAction("step3");

        }

        public ActionResult step3()
        {

            return View(new RegistrationStep3Model());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult step3(RegistrationStep3Model cr)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Landing");
            }
            else
            {
                return View();
            }
        }
    }
}
