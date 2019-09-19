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
        public string First { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string Last { get; set; }

        [Required(ErrorMessage = "Please add your programming interests")]
        public string Interests { get; set; }

        public string City { get; set; }
        //public int Age { get; set; }
    }
}
