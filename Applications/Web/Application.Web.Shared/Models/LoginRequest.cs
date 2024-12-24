using System.ComponentModel.DataAnnotations;

namespace Applications.Web.Shared.Models
{
    public class LoginRequest
    {
        [Required]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
