using AmidmedClinic.Models;
using AmidmedClinic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Branches> Branches { get; set; }
   
        public DbSet<Campaigns> Campaigns { get; set; }

        public DbSet<Patients> Patients { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Partners> Partners { get; set; }

      
        public DbSet<DoctorsPatients> DoctorsPatients { get; set; }
 
        public DbSet<Vacancies> Vacancies { get; set; }
        public DbSet<Managment> Managment { get; set; }
        public DbSet<Incomes> Incomes { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Kassa> Kassa { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Kassa>().HasData(new Kassa { Id = 1, Balance = 0 });
        }
    }
}
