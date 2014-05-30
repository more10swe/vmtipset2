using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VM_Tipset_2.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Användarnamn:")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord:")]
        public string Password { get; set; }
    }
}