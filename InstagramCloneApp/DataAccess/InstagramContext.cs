using InstagramCloneApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramCloneApp.DataAccess
{
    public class InstagramContext : DbContext
    {
        public InstagramContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
