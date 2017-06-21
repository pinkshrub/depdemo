using System.ComponentModel.DataAnnotations;

namespace logdemo.Models
{
    public class RegViewModel : BaseEntity
    {
        [Required]
        [MinLength(2)]
        public string Name {get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Passwords must match yo!")]
        public string password_confirm { get; set; }
    }
}