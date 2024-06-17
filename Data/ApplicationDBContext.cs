using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace core.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public DbSet<User> User { get; set;}
        public DbSet<Todo> Todo { get; set;}
        public DbSet<Comment> Comment { get; set;}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
            Console.WriteLine("OnModelCreating called -------------------------");
             var users = new User[20];
            for (int i = 1; i <= 20; i++)
            {
                users[i - 1] = new User
                {
                    Id = i,
                    Name = $"User {i}",
                    Lastname = $"Lastname {i}",
                    Email = $"email{1}@email.com"                    
                };
            }
            modelBuilder.Entity<User>().HasData(users);
        }
        
    }
}