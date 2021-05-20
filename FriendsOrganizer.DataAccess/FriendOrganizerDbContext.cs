using FriendsOrganizer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace FriendsOrganizer.DataAccess
{
    public class FriendOrganizerDbContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Friend>().HasData(new List<Friend>
            {
                new() { Id = Guid.NewGuid(), FirstName = "Mahmudul", LastName = "Hasan" },
                new() { Id = Guid.NewGuid(), FirstName = "Ariful", LastName = "Islam" },
                new () { Id = Guid.NewGuid(), FirstName = "Zakir", LastName = "Hossen" },
                new () { Id = Guid.NewGuid(), FirstName = "Ashiqur", LastName = "Rahman" }
            });

        }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FriendOrganization;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
