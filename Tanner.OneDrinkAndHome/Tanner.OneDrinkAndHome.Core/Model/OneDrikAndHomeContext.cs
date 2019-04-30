using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tanner.OneDrinkAndHome.Core.Entities;

namespace Tanner.OneDrinkAndHome.Core.Model
{
    public class OneDrikAndHomeContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Party> Parties { get; set; }

        public DbSet<Place> Places { get; set; }

        public OneDrikAndHomeContext(DbContextOptions<OneDrikAndHomeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Account

            builder.Entity<Account>()
                .Property(c => c.Type)
                .HasConversion<string>();

            #endregion

            #region CustomerParty

            builder.Entity<CustomerParty>()
                .HasKey(t=> new { t.PartyID, t.CustomerID });
            builder.Entity<CustomerParty>()
                .HasOne(t => t.Party)
                .WithMany(t => t.Customers)
                .HasForeignKey(t => t.PartyID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<CustomerParty>()
                .HasOne(t => t.Customer)
                .WithMany(t => t.Parties)
                .HasForeignKey(t => t.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Customer

            builder.Entity<Customer>()
                .HasIndex(t => t.RUT);
            builder.Entity<Customer>()
                .Property(t => t.RUT)
                .HasMaxLength(12);
            builder.Entity<Customer>()
                .HasIndex(t => t.Email);

            #endregion
                       
            base.OnModelCreating(builder);
        }
    }
}
