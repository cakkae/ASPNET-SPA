using System.ComponentModel.DataAnnotations;

namespace NETAPI.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specified password between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}