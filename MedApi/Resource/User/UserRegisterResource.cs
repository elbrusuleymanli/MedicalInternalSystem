using System.ComponentModel.DataAnnotations;


namespace MedApi.Resource.User
{
    public class UserRegisterResource
    {
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProfilePhoto { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
