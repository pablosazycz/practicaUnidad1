using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace practicaUnidad1.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        // relaciones
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}
