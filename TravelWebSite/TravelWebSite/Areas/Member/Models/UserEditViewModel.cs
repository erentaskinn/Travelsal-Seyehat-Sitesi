namespace TravelWebSite.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }
        public string phoneNumber { get; set; }
        public string Email { get; set; }
        public string imageUrl { get; set; }
        public IFormFile Image { get; set; }

    }
}
