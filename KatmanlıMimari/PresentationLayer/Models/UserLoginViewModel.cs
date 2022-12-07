using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen parolanızı giriniz")]
        public string Password { get; set; }
    }
}
