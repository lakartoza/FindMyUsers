using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMyUsers.Models
{
    public class User
    {
        public long Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
    }
}
