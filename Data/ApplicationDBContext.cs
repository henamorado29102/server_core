using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using Microsoft.EntityFrameworkCore;

namespace core.Data
{
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options) 
    {
        public DbSet<User> User { get; set;}
        public DbSet<Todo> Todo { get; set;}
        public DbSet<Comment> Comment { get; set;}
        
    }
}