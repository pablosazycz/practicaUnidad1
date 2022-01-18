using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace practicaUnidad1.Entities
{
    internal class Posts
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public User User { get; set; }


    }
}
