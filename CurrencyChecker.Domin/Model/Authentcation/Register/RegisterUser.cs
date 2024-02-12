using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyChecker.Domin.Model.Authentcation.Register
{
    public class RegisterUser
    {
        public Guid RegisterUserId { get; set; }
        [Required(ErrorMessage ="Pleace Enter Firest Name")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Pleace Enter Last Name")]
        public string LName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Pleace Enter Your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pleace Enter Your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Pleace Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage ="The Password Is Not Confirm")]
        public string ConfirmPassword { get; set; }

        public string Pnorties { get; set; }
    }
}
