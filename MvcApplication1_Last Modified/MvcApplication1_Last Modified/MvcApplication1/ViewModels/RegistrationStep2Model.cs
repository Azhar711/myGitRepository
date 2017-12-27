using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.ViewModels
{
    public class RegistrationStep2Model
    {
        [Required(ErrorMessage = "* You must select one of the verification option.")]
        [Display(Name = "Mobile Activation")]
        public string MobVerify { get; set; }

        [Required(ErrorMessage = "You must select one of the verification option.")]
        [Display(Name = "Email")]
        public string _Email { get; set; }

        [Required(ErrorMessage = "You must select one of the verification option.")]
        public string verify { get; set; }

        public string Mobile { get; set; }



        
        [Display(Name = "Enter Activation Code Here")]
        public string ActivationCode { get; set; }

        
    }
}