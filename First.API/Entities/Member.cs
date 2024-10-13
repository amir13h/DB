using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.API.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
    }
}