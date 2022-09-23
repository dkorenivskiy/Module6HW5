using System.ComponentModel.DataAnnotations;

namespace Homework4.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
