using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Liütfen kullanıcı adını giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Liütfen kullanıcı şifrenizi giriniz")]
        public string Password { get; set; }

    }
}
