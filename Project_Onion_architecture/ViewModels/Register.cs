using System.ComponentModel.DataAnnotations;

namespace Project_Onion_architecture.ViewModels
{
    public class Register
    {
        [Required]
        [Display(Name = "User Name")]
        public string  UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {  get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword {  get; set; }

    }
}
