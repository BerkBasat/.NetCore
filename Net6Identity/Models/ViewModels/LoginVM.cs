using System.ComponentModel.DataAnnotations;

namespace Net6Identity.Models.ViewModels
{
    public class LoginVM
    {

        [Required(ErrorMessage = "email  gerekli")]
        public string Email { get; set; }

        [Required(ErrorMessage = "şifre adı gerekli")]
        public string Password { get; set; }

    }
}