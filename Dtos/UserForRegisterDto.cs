using System.ComponentModel.DataAnnotations;

namespace GuyubApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "You must specify password between 6 to 15 character")]
        public string Password { get; set; }
    }
}