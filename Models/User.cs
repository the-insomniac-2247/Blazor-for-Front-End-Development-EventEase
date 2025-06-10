using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Must input a valid email address.")]
        public string Email { get; set; }
    }
}