using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practicaUnidad1.Entities;


namespace practicaUnidad1.Context
{
    internal class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
        //Entities
        public DbSet<Entities.Comments> Commentss { get; set; }
        public DbSet<Entities.Posts> Post { get; set; }
        public DbSet<Entities.User> Users { get; set; }

    }
}

