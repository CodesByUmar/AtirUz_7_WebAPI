using System.ComponentModel.DataAnnotations;

namespace AtirAPI.DTOs
{
    public class CustomerCreateDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}