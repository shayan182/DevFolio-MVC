using System.ComponentModel.DataAnnotations;

namespace DevFolio_MVC.Models
{
    public class Comment
    {
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [EmailAddress(ErrorMessage = "The value of the email entered is incorrect!")]
        public string Email { get; set; }
        public string Website { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MinLength(3, ErrorMessage = "The minimum Comment length is 3 characters!")]
        public string Text { get; set; }

    }
}
