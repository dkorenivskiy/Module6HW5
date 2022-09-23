using System.ComponentModel.DataAnnotations;

namespace Homework4.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please Enter your Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Incorect Password")]
        public string? ConfirmPassword { get; set; }
    }
}
