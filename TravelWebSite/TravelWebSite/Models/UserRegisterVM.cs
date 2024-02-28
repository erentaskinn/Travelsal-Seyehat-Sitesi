using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class UserRegisterVM
	{
		[Required(ErrorMessage ="Lütfen Adınzı Giriniz")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen Email Giriniz")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Lütfen şifrenizi Giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen şifreyi tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }
	}
}
