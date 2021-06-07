using System.ComponentModel.DataAnnotations;


namespace Application.DTOs.Users
{
    public class LoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
