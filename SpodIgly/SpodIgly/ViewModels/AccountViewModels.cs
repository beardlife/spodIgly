using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpodIgly.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Podaj login")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Podaj hasło")]
        public string Password { get; set; }
        
        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100,ErrorMessage="The {0} must be at least {2} characters long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password does not match")]
        public string ConfirmPassword { get; set; }
    }
}