using System.ComponentModel.DataAnnotations;

namespace Applications.Web.MvcApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Enter password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
