﻿using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace WebApplication3.Models
{
    public class BankContext : DbContext 
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankBranch>().HasData(
                new BankBranch
                {
                    Id = 1,
                    LocationName = "Alkairan Mall Branch",
                    BranchManager = "Omar Alghanem",
                    EmployeeCount = 6,
                    LocationURL = "https://maps.app.goo.gl/k5DD4wvKX38Y6RFQ7"
                }
            );
        }

        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}