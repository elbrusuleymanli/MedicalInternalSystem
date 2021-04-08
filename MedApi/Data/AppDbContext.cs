using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
  

