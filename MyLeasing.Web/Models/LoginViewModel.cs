using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    public class LoginViewModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
