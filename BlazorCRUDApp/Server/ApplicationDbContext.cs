using BlazorCRUDApp.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Server
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var people = new List<Person>();
            for (int i = 6; i < 106; i++)
            {
                people.Add(new Person() { Id = i, Name = $"Person {i}" });
            }

            builder.Entity<Person>().HasData(people);

            base.OnModelCreating(builder);
        }

        public DbSet<Person> People { get; set; }
    }
}
