using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Users
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
