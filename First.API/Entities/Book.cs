using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.API.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Pages { get; set; }
    }
}