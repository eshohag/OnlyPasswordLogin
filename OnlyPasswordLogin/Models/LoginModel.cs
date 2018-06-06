using System.ComponentModel.DataAnnotations;

namespace OnlyPasswordLogin.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}