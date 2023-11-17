using System.ComponentModel.DataAnnotations;

namespace Seminar_1.Models
{
    public class LoginVM
    {
        public LoginVM()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}
