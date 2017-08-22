using System.ComponentModel.DataAnnotations;

namespace PartyInviteMVC5WebApp.Models
{
    public class GuestResponse
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name cannot be null or empty")]
        [MaxLength(10)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        //[Required(ErrorMessage = "Last Name cannot be null or empty")]
        [MaxWords(1)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone cannot be empty")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter a valid Email Address")]
        public string Email { get; set; }

        [Required, Range(14, 80, ErrorMessage = "Age has to be between 14 to 80")]
        public int Age { get; set; }

        [Display(Name = "Will Attend")]
        [Required(ErrorMessage = "Please choose a option")]
        public bool? WillAttend { get; set; }
    }
}