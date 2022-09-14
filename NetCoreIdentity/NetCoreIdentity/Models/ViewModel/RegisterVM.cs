using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        [Display(Name ="Kullanıcı adı")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage ="Lütfen email formatında bir adres girin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre (Tekrar) boş geçilemez!")]
        [Compare("Password",ErrorMessage ="şifreler uyuşmuyor!")]
        [Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }
    }
}
