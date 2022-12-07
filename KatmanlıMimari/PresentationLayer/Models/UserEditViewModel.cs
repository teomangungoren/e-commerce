using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isminizi giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string LastName { get; set; }
        
        
        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı onaylayınız")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerinizin uyuştuğuna emin olunuz")]
        public string ConfirmPassword { get; set; }

    }
}
