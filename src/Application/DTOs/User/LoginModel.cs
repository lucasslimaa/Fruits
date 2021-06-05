using System.ComponentModel.DataAnnotations;


namespace Application.DTOs.User
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
