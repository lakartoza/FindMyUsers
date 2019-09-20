using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindMyUsers.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(60, ErrorMessage ="First Name is too long, please shorten")]
        public string First { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(60, ErrorMessage = "Last Name is too long, please shorten")]
        public string Last { get; set; }

        [Required(ErrorMessage = "Please add your programming interests")]
        public string Interests { get; set; }

        [Required(ErrorMessage = "Please add your location city")]
        public string City { get; set; }
        //public int Age { get; set; }
    }
}
