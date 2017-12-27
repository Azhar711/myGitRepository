using MvcApplication1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MemberController : Controller
    {
        //
        // GET: /Member/

        public ActionResult InitiateRegistration()
        {
            return View(new RegisterViewModel());
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult InitiateRegistration(RegisterViewModel vm)
        {
            vm.checkagree = true;

            if (ModelState.IsValid)
            {
                return RedirectToAction("step2"); 
            }
            else
            {
                return View("InitiateRegistration");
            }
        }
        public ActionResult step2()
        {

            return View(new RegistrationStep2Model());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult step2(RegistrationStep2Model vm2)
        {
            
                return RedirectToAction("step3");
            
        }

        public ActionResult step3()
        {

            return View(new RegistrationStep3Model());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult step3(RegistrationStep3Model vm3)
        {
            if (ModelState.IsValid) { 
                return RedirectToAction("Landing");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Landing()
        {

            return View();
        }
        
    }
}
