using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.ViewModels
{
    public class CareGiverRegisterModel
    {
        [Required(ErrorMessage = "* Please enter your First Name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Please enter your Last Name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


       

        [Required(ErrorMessage = "* Please enter your Email ID.")]
        [EmailAddress(ErrorMessage = "Enter a Valid Email Address")]
        [Display(Name = "Email Id")]
        public string Email { get; set; }


        [Required(ErrorMessage = "* Please enter your Phone.")]
        [Phone(ErrorMessage = "Please Enter the Valid Phone Number ")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "* You must agree with the Terms of Use and Privacy Policy.")]
        [Display(Name = " I agree to the Terms of Use and the Privacy Policy . *")]
        public bool checkagree { get; set; }
    }
}