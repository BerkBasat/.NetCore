using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
