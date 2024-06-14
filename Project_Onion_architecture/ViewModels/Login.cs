using System.ComponentModel.DataAnnotations;

namespace Project_Onion_architecture.ViewModels
{
    public class Login
    {
        [Required]
        [Display(Name ="User Name")]
        public string ?UserName { get; set; }
        [Required(ErrorMessage ="Invalid Password")]
        [DataType(DataType.Password)]
        public string ?Password { get; set; }
    }
}
