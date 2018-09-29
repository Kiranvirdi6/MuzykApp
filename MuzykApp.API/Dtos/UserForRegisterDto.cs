using System.ComponentModel.DataAnnotations;

namespace MuzykApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="You must specify the length between 4 and 8")]
        public string Password { get; set; }
    }
}