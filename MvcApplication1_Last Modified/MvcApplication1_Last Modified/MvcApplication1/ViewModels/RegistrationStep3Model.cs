using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.ViewModels
{
    public class RegistrationStep3Model
    {
        [Required(ErrorMessage = "Username is Required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm is Required")]
        [Compare("Password", ErrorMessage="Confirm password should be same as Password")]
        [Display(Name = "Confirm password")]
        public string CPassword { get; set; }
    }
}