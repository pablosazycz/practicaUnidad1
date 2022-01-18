using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace practicaUnidad1.Entities
{
    internal class Comments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public User User { get; set; }

        
    }
}
