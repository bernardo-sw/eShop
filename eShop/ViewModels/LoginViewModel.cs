using System.ComponentModel.DataAnnotations;

namespace eShop.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please provide the Username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter the password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}