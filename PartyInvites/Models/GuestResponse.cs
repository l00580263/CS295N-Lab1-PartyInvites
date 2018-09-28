using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {

        #region properties
        [Required(ErrorMessage = "Please Enter your Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Email.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Phone.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Specify your Attendance.")]
        public bool? WillAttend { get; set; }
        #endregion
    }
}
