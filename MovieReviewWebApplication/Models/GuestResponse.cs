using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebApplication.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please, enter yout name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter your e-mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}