using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevFolio_MVC.Models
{
    public class Message
    {
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }                
        [Required(ErrorMessage = "This field is required!")]
        [EmailAddress(ErrorMessage = "The value of the email entered is incorrect!")]
        public string Email { get; set; }               
        [Required(ErrorMessage = "This field is required!")]
        public string Subject { get; set; }             
        [Required(ErrorMessage = "This field is required!")]
        [MinLength(3 , ErrorMessage = "The minimum message length is 3 characters!")]
        public string message { get; set; }

    }
}
