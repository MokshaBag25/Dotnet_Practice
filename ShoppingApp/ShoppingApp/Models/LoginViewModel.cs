using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace ShoppingApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your user name")]
        [EmailAddress(ErrorMessage = "Invalid user  name")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
