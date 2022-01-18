using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleApp2.Entities;

namespace ConsoleApp2.Context
{
    internal class BlogContext : DbContext
    {
        
        //Entities
        public DbSet<Comments> Commentss { get; set; }
        public DbSet<Posts> Post { get; set; }
        public DbSet<User> Users { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BZJFAR03\\SQLEXPRESS;Database=BlogContext;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }


    }
}
