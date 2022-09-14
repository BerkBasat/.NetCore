using System.ComponentModel.DataAnnotations;

namespace Net6Identity.Models.ViewModels
{
    public class RegisterVm
    {

        [Required(ErrorMessage = "kullanıcı adı gerekli")]
        public string Username { get; set; }
        [Required(ErrorMessage = "email adı gerekli")]
        public string Email { get; set; }
        [Required(ErrorMessage = "şifre adı gerekli")]
        public string Password { get; set; }
        [Required(ErrorMessage = "şifre(tekrar) adı gerekli")]
        [Compare("Password", ErrorMessage = "şifreler eşleşmiyor!")]
        public string ConfirmPassword { get; set; }
    }
}